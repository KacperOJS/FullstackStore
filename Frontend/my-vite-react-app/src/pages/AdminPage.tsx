import { useState, useEffect } from 'react';
import { Line } from 'react-chartjs-2';
import 'chart.js/auto'; // Import chart.js for chart support
import '../styles/AdminPage.css'; // Import CSS

const AdminPage = () => {
  const [moneyData, setMoneyData] = useState<number[]>([0, 0, 0]); 
  const [userData, setUserData] = useState<number[]>([0, 0, 0]); 
  const [users, setUsers] = useState<any[]>([]);


  useEffect(() => {
    const fetchChartData = async () => {
  
      const fetchedMoneyData = await fetch('http://localhost:5250/api/Logs/paymentlogs').then(res => res.json());

      // Sort the fetched money data by date
	  const sortedMoneyData = fetchedMoneyData.sort((a: any, b: any) => {
		return new Date(a.date).getTime() - new Date(b.date).getTime();
	  });	  

      const todayAmount = sortedMoneyData
        .filter((e: any) => isToday(new Date(e.date)))
        .map((e: any) => e.amount);

      const sevenDaysAmount = sortedMoneyData
        .filter((e: any) => isWithinDays(new Date(e.date), 7))
        .map((e: any) => e.amount);

      const thirtyDaysAmount = sortedMoneyData
        .filter((e: any) => isWithinDays(new Date(e.date), 30))
        .map((e: any) => e.amount);

      setMoneyData([todayAmount, sevenDaysAmount, thirtyDaysAmount].map(arr => arr.reduce((acc:any, val:any) => acc + val, 0)));

      // Example of fetching user data (replace this with real API calls)
      const fetchedUserData = await fetch('/api/users/stats').then(res => res.json());
      
      const userToday = fetchedUserData.today;
      const userSevenDays = fetchedUserData.last7Days;
      const userThirtyDays = fetchedUserData.last30Days;

      setUserData([userToday, userSevenDays, userThirtyDays]);
    };

    const fetchAllUsers = async () => {
      const fetchedUsers = await fetch('http://localhost:5250/api/Customer').then(res => res.json());
	  fetchedUsers.map((e:any)=>{
		console.log(e);
		
	  })
      setUsers(fetchedUsers);
    };

    fetchChartData();
    fetchAllUsers();
  }, []);

  // Helper functions for filtering dates
  const isToday = (date: Date) => {
    const today = new Date();
    return date.toDateString() === today.toDateString();
  };

  const isWithinDays = (date: Date, days: number) => {
    const today = new Date();
    const daysAgo = new Date(today.setDate(today.getDate() - days));
    return date >= daysAgo;
  };

  // Define chart data and options
  const moneyChartData = {
    labels: ['Today', 'Last 7 Days', 'Last 30 Days'],
    datasets: [
      {
        label: 'Total Amount of Money',
        data: moneyData, // Array of numbers for 'Today', 'Last 7 Days', 'Last 30 Days'
        borderColor: 'rgba(75, 192, 192, 1)',
        backgroundColor: 'rgba(75, 192, 192, 0.2)',
        fill: true,
      },
    ],
  };

  const userChartData = {
    labels: ['Today', 'Last 7 Days', 'Last 30 Days'],
    datasets: [
      {
        label: 'Total Users Increase/Decrease',
        data: userData, // Array of numbers for 'Today', 'Last 7 Days', 'Last 30 Days'
        borderColor: 'rgba(153, 102, 255, 1)',
        backgroundColor: 'rgba(153, 102, 255, 0.2)',
        fill: true,
      },
    ],
  };

  return (
    <div className="admin-dashboard-container">
      <h1 className="dashboard-title">Admin Dashboard</h1>

      <div className="dashboard-charts">
        <div className="chart-wrapper">
          <h2 className="chart-title">Total Money Stats</h2>
          <Line data={moneyChartData} />
        </div>

        <div className="chart-wrapper">
          <h2 className="chart-title">User Stats</h2>
          <Line data={userChartData} />
        </div>
      </div>

      <h2 className="user-table-title">All Users</h2>
      <table className="user-table">
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Email</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody>
          {users.map(user => (
            <tr key={user.id}>
              <td>{user.id}</td>
              <td>{user.name}</td>
              <td>{user.email}</td>
			  <td>
                <button className="btn-edit" disabled={user.admin===1}>Edit</button>
                <button className="btn-delete" disabled={user.admin===1}>Delete</button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default AdminPage;

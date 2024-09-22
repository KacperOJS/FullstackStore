import { useState, useEffect } from 'react';
import { Line } from 'react-chartjs-2';
import 'chart.js/auto'; // Import chart.js for chart support
import '../styles/AdminPage.css'; // Import CSS

const AdminPage = () => {
  const [moneyData, setMoneyData] = useState<number[]>([0, 0, 0]);
  const [userData, setUserData] = useState<number[]>([0, 0, 0]);
  const [users, setUsers] = useState<any[]>([]);
  const [selectedUser, setSelectedUser] = useState<any>(null); // State for the selected user
  const [isModalOpen, setIsModalOpen] = useState<boolean>(false); // State for modal visibility
  const [actionType, setActionType] = useState<string>(''); // State to distinguish between edit and delete actions
  const [editForm, setEditForm] = useState({ name: '', email: '' }); // Form state for editing

  useEffect(() => {
    const fetchChartData = async () => {
      const fetchedMoneyData = await fetch('http://localhost:5250/api/Logs/paymentlogs').then(res => res.json());

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

      const fetchedUserData = await fetch('/api/users/stats').then(res => res.json());

      const userToday = fetchedUserData.today;
      const userSevenDays = fetchedUserData.last7Days;
      const userThirtyDays = fetchedUserData.last30Days;

      setUserData([userToday, userSevenDays, userThirtyDays]);
    };

    const fetchAllUsers = async () => {
      const fetchedUsers = await fetch('http://localhost:5250/api/Customer').then(res => res.json());
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

  // Function to handle the "Edit" and "Delete" button click
  const handleActionClick = (user: any, action: string) => {
    setSelectedUser(user); // Set the selected user data
    setActionType(action); // Set the action type (edit or delete)
    if (action === 'edit') {
      setEditForm({ name: user.name, email: user.email }); // Initialize the form with user data
    }
    setIsModalOpen(true);  // Show the modal
  };

  // Function to close the modal
  const closeModal = () => {
    setIsModalOpen(false);
    setSelectedUser(null);
  };

  // Function to handle edit form submission
  const handleEditSubmit = async (e: any) => {
    e.preventDefault();
    // Send updated data to API
    const response = await fetch(`http://localhost:5250/api/Customer/${selectedUser.id}`, {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(editForm),
    });

    if (response.ok) {
      const updatedUser = await response.json();
      setUsers(prev => prev.map(user => (user.id === updatedUser.id ? updatedUser : user))); // Update user in the state
      closeModal();
    } else {
      alert('Failed to update user');
    }
  };

  // Function to handle delete confirmation
  const handleDeleteConfirm = async () => {
    if (window.confirm(`Are you sure you want to delete ${selectedUser?.name}? This action cannot be undone.`)) {
        const response = await fetch(`http://localhost:5250/api/Customer/${selectedUser.id}`, {
            method: 'DELETE',
        });

        if (response.ok) {
            setUsers(prev => prev.filter(user => user.id !== selectedUser.id)); // Remove user from the state
            closeModal();
        } else {
            const errorText = await response.text(); // Get error message
            alert(`Failed to delete user: ${errorText}`);
        }
    }
};


  // Define chart data and options
  const moneyChartData = {
    labels: ['Today', 'Last 7 Days', 'Last 30 Days'],
    datasets: [
      {
        label: 'Total Amount of Money',
        data: moneyData,
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
        data: userData,
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
                <button
                  onClick={() => handleActionClick(user, 'edit')}
                  className="btn-edit"
                  disabled={user.admin === 1}
                >
                  Edit
                </button>
                <button
                  onClick={() => handleActionClick(user, 'delete')}
                  className="btn-delete"
                  disabled={user.admin === 1}
                >
                  Delete
                </button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>

      {isModalOpen && (
        <>
          <div className="modal-overlay"></div> {/* Blurred background */}
          <div className="modal">
            <div className="modal-content">
              {actionType === 'edit' ? (
                <form onSubmit={handleEditSubmit}>
                  <label>Name:</label>
                  <input
                    type="text"
                    value={editForm.name}
                    onChange={(e) => setEditForm({ ...editForm, name: e.target.value })}
                  /><br/>
                  <label>Email:</label>
                  <input
                    type="email"
                    value={editForm.email}
                    onChange={(e) => setEditForm({ ...editForm, email: e.target.value })}
                  /><br/>
                  <button type="submit" className="btn-edit">Save Changes</button>
                </form>
              ) : (
                <>
                  <p>Are you sure you want to delete user {selectedUser?.name}?</p>
                  <button onClick={handleDeleteConfirm} className="btn-delete">Confirm Delete</button>
                </>
              )}
              <button className="btn-close" onClick={closeModal}>Close</button>
            </div>
          </div>
        </>
      )}
    </div>
  );
};

export default AdminPage;

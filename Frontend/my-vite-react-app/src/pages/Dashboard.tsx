import { useEffect, useState } from 'react';
import { useNavigate } from 'react-router-dom';
import '../styles/Dashboard.css';
import EditModal from './EditModal';
import '../styles/EditModal.css';

  
interface Transaction {
	id: number;
	date: string;
	amount: string;
	status: string;
	customer:any;
  }

const Dashboard: React.FC = () => {
  const navigate = useNavigate();
  const [userDetails, setUserDetails] = useState<any>(null);
  const [transactions2, setTransactions2] = useState<any[]>([]);
  const [isModalOpen, setIsModalOpen] = useState<boolean>(false);


  useEffect(() => {
    logDataUserTransactions();
  }, []);

  const logDataUserTransactions = async ()=>{
    const response = await fetch("http://localhost:5250/api/Logs/paymentlogs");
	const data: Transaction[] = await response.json();
	const userId = localStorage.getItem('userId');
	const filteredData = data.filter(transaction => transaction.customer.id === Number(userId));  
	setTransactions2(filteredData);
	console.log(filteredData);
  }
  useEffect(() => {
    const isLoggedIn = localStorage.getItem('isLoggedIn') === 'true';
    if (!isLoggedIn) {
      navigate('/login');
    }

    const name = localStorage.getItem('username');
    const email = localStorage.getItem('email');

    setUserDetails({
      name,
      email,
    });

  }, [navigate]);

  const handleLogout = () => {
    localStorage.removeItem('isLoggedIn');
    localStorage.removeItem('userId');
    localStorage.removeItem('username');
    localStorage.removeItem('email');
    window.location.reload();
  };

  const handleEditClick = () => {
    setIsModalOpen(true);
  };

  const handleCloseModal = () => {
    setIsModalOpen(false);
  };

  const handleUpdate = (updatedDetails: any) => {
    localStorage.setItem('username', updatedDetails.username);
    localStorage.setItem('email', updatedDetails.email);
    setUserDetails(updatedDetails);
    handleCloseModal();
  };

  return (
    <div className="dashboard-container">
      <header className="dashboard-header">
        <h2>Client Dashboard</h2>
        <button className="dashboard-logout-button" onClick={handleLogout}>
          Logout
        </button>
      </header>

      <section className="dashboard-user-info">
        <h2>User Profile</h2>
        {userDetails && (
          <div className="user-details">
            <p><strong>Name:</strong> {userDetails.name}</p>
            <p><strong>Email:</strong> {userDetails.email}</p>
            <button className="edit-button" onClick={handleEditClick}>Edit</button>
          </div>
        )}
      </section>

      <section className="dashboard-transactions">
        <h2>Recent Transactions</h2>
        <table className="transactions-table">
          <thead>
            <tr>
              <th>Date</th>
              <th>Amount</th>
              <th>Status</th>
            </tr>
          </thead>
          <tbody>
            {transactions2.map((transaction) => (
              <tr key={transaction.id}>
                <td>{transaction.date}</td>
                <td>{transaction.amount}</td>
				<td className={`status${transaction.status}`}>
              	{transaction.status === 1 ? 'Completed' : 
               transaction.status === 2 ? 'Pending' : 
               transaction.status === 3 ? 'Failed' : 
               'Unknown'}
            </td>
			
              </tr>
            ))}
          </tbody>
        </table>
      </section>

      {isModalOpen && (
        <EditModal 
          currentDetails={userDetails} 
          onClose={handleCloseModal} 
          onUpdate={handleUpdate} 
        />
      )}
    </div>
  );
};

export default Dashboard;

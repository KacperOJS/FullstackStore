import { useEffect, useState } from 'react';
import { useNavigate } from 'react-router-dom';
import '../styles/Dashboard.css';
import EditModal from './EditModal';
import '../styles/EditModal.css';

const Dashboard: React.FC = () => {
  const navigate = useNavigate();
  const [userDetails, setUserDetails] = useState<any>(null);
  const [transactions, setTransactions] = useState<any[]>([]);
  const [isModalOpen, setIsModalOpen] = useState<boolean>(false);

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

    setTransactions([
      { id: 1, date: '2024-09-01', amount: '50 PLN', status: 'Completed' },
      { id: 2, date: '2024-09-05', amount: '100 PLN', status: 'Pending' },
      { id: 3, date: '2024-09-10', amount: '75 PLN', status: 'Failed' },
    ]);
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
        <h1>Client Dashboard</h1>
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
            {transactions.map((transaction) => (
              <tr key={transaction.id}>
                <td>{transaction.date}</td>
                <td>{transaction.amount}</td>
                <td className={`status-${transaction.status.toLowerCase()}`}>
                  {transaction.status}
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

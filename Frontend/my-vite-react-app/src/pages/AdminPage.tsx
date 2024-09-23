// AdminPage.tsx

import React, { useState, useEffect } from 'react';
import { Line, Doughnut } from 'react-chartjs-2'; // Import Doughnut chart
import 'chart.js/auto'; // Import Chart.js for chart support
import '../styles/AdminPage.css'; // Import CSS

// Define interfaces for data structures
interface PaymentLog {
  date: string; // ISO date string
  amount: number;
}

interface User {
  id: number;
  name: string;
  email: string;
  spend: number;
  phone: string;
  registrationDate: string; // ISO date string
}

const AdminPage: React.FC = () => {
  // State for daily payment totals
  const [moneyData, setMoneyData] = useState<number[]>([]);
  const [paymentLabels, setPaymentLabels] = useState<string[]>([]);

  // State for daily user registrations
  const [userRegistrationCounts, setUserRegistrationCounts] = useState<number[]>([]);
  const [userRegistrationDetails, setUserRegistrationDetails] = useState<Record<string, string[]>>({});
  const [userRegistrationLabels, setUserRegistrationLabels] = useState<string[]>([]);

  // State for all users
  const [users, setUsers] = useState<User[]>([]);

  // Modal-related states
  const [selectedUser, setSelectedUser] = useState<User | null>(null);
  const [isModalOpen, setIsModalOpen] = useState<boolean>(false);
  const [actionType, setActionType] = useState<string>('');
  const [editForm, setEditForm] = useState({ name: '', email: '' });

  // Loading and error states
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    const fetchChartData = async () => {
      try {
        // Fetch payment logs
        const fetchedMoneyData: PaymentLog[] = await fetch('http://localhost:5250/api/Logs/paymentlogs')
          .then(res => res.json());

        // Process daily payments
        const dailyPayments: Record<string, number> = {};

        fetchedMoneyData.forEach((log) => {
          const logDate = new Date(log.date).toLocaleDateString(); // e.g., "9/23/2024"
          dailyPayments[logDate] = (dailyPayments[logDate] || 0) + log.amount;
        });

        // Sort dates in ascending order
        const sortedPaymentDates = Object.keys(dailyPayments).sort(
          (a, b) => new Date(a).getTime() - new Date(b).getTime()
        );

        const sortedDailyPayments = sortedPaymentDates.map(date => dailyPayments[date]);

        setMoneyData(sortedDailyPayments);
        setPaymentLabels(sortedPaymentDates);

        // Fetch all users
        const fetchedUsers: User[] = await fetch('http://localhost:5250/api/Customer')
          .then(res => res.json());

        // Filter out unnecessary fields by mapping
        const filteredUsers: User[] = fetchedUsers.map(user => ({
          id: user.id,
          name: user.name,
          email: user.email,
          spend: user.spend ,
          phone: user.phone,
          registrationDate: user.registrationDate,
        }));

        setUsers(filteredUsers);

        // Process daily user registrations
        const dailyUserRegistrations: Record<string, string[]> = {};

        filteredUsers.forEach((user) => {
          const regDate = new Date(user.registrationDate).toLocaleDateString();
          if (!dailyUserRegistrations[regDate]) {
            dailyUserRegistrations[regDate] = [];
          }
          dailyUserRegistrations[regDate].push(user.name);
        });

        // Sort dates in ascending order
        const sortedUserDates = Object.keys(dailyUserRegistrations).sort(
          (a, b) => new Date(a).getTime() - new Date(b).getTime()
        );

        const sortedDailyUserRegistrations = sortedUserDates.map(date => dailyUserRegistrations[date].length);

        setUserRegistrationCounts(sortedDailyUserRegistrations);
        setUserRegistrationDetails(dailyUserRegistrations);
        setUserRegistrationLabels(sortedUserDates);
      } catch (err) {
        console.error('Error fetching chart data:', err);
        setError('Failed to load data. Please try again later.');
      } finally {
        setLoading(false);
      }
    };

    fetchChartData();
  }, []);

  // Handler for action buttons (Edit/Delete)
  const handleActionClick = (user: User, action: string) => {
    setSelectedUser(user);
    setActionType(action);
    if (action === 'edit') {
      setEditForm({ name: user.name, email: user.email });
    }
    setIsModalOpen(true);
  };

  // Close modal
  const closeModal = () => {
    setIsModalOpen(false);
    setSelectedUser(null);
  };

  // Handle edit form submission
  const handleEditSubmit = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    if (!selectedUser) return;

    try {
      const response = await fetch(`http://localhost:5250/api/Customer/${selectedUser.id}`, {
        method: 'PUT',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify(editForm),
      });

      if (response.ok) {
        const updatedUser: User = await response.json();
        setUsers(prev => prev.map(user => (user.id === updatedUser.id ? updatedUser : user)));
        closeModal();
      } else {
        const errorText = await response.text();
        alert(`Failed to update user: ${errorText}`);
      }
    } catch (err) {
      console.error('Error updating user:', err);
      alert('Failed to update user');
    }
  };

  // Handle delete confirmation
  const handleDeleteConfirm = async () => {
    if (!selectedUser) return;

    if (window.confirm(`Are you sure you want to delete user "${selectedUser.name}"? This action cannot be undone.`)) {
      try {
        const response = await fetch(`http://localhost:5250/api/Customer/${selectedUser.id}`, {
          method: 'DELETE',
        });

        if (response.ok) {
          setUsers(prev => prev.filter(user => user.id !== selectedUser.id));
          closeModal();
        } else {
          const errorText = await response.text();
          alert(`Failed to delete user: ${errorText}`);
        }
      } catch (err) {
        console.error('Error deleting user:', err);
        alert('Failed to delete user');
      }
    }
  };

  // Prepare chart data for daily payments
  const moneyChartData = {
    labels: paymentLabels, // Use actual dates
    datasets: [
      {
        label: 'Daily Payment Amounts',
        data: moneyData,
        borderColor: 'rgba(75, 192, 192, 1)',
        backgroundColor: 'rgba(75, 192, 192, 0.2)',
        fill: true,
      },
    ],
  };

  // Prepare chart data for daily user registrations (Line Chart)
  const userChartData = {
    labels: userRegistrationLabels, // Use actual dates
    datasets: [
      {
        label: 'Daily New User Registrations',
        data: userRegistrationCounts,
        borderColor: 'rgba(153, 102, 255, 1)',
        backgroundColor: 'rgba(153, 102, 255, 0.2)',
        fill: true,
      },
    ],
  };

  // Prepare chart data for daily user registrations (Doughnut Chart)
  const getRandomColor = () => {
	const letters = '0123456789ABCDEF';
	let color = '#';
	for (let i = 0; i < 6; i++) {
	  color += letters[Math.floor(Math.random() * 16)];
	}
	return color;
  };
  
  const userDoughnutData = {
	labels: [], // No user names as labels
	datasets: [
	  {
		label: 'Daily New User Registrations',
		data: userRegistrationCounts,
		backgroundColor: users.map(() => getRandomColor()), // Generate random colors
		borderColor: '#fff', // Add border color for better contrast
		borderWidth: 2,
	  },
	],
  };
  

  // Customize chart options
  const chartOptions = {
    responsive: true,
    maintainAspectRatio: false,
    scales: {
      y: {
        beginAtZero: true,
        title: {
          display: true,
          text: 'Amount / Count',
        },
      },
      x: {
        title: {
          display: true,
          text: 'Date',
        },
      },
    },
    plugins: {
      tooltip: {
        callbacks: {
          // Customize tooltip labels
          label: (tooltipItem: any) => {
            const datasetLabel = tooltipItem.dataset.label;
            if (datasetLabel === 'Daily Payment Amounts') {
              return `Payment: $${tooltipItem.raw}`;
            } else if (datasetLabel === 'Daily New User Registrations') {
              const dateKey = userChartData.labels[tooltipItem.dataIndex];
              const userNames = userRegistrationDetails[dateKey] || [];
              return `Users: ${tooltipItem.raw}\nNames: ${userNames.join(', ')}`;
            }
            return '';
          },
        },
        // Enable multi-line tooltips
        mode: 'index' as const,
        intersect: false,
      },
      legend: {
        display: true,
        position: 'top' as const,
      },
    },
  };

  return (
    <div className="admin-dashboard-container">
      <h1 className="dashboard-title">Admin Dashboard</h1>

      {loading ? (
        <div className="loading">Loading data...</div>
      ) : error ? (
        <div className="error-message">{error}</div>
      ) : (
        <>
          <div className="dashboard-charts">
            {/* Daily Payment Chart */}
            <div className="chart-wrapper">
              <h2 className="chart-title">Daily Payment Stats</h2>
              <div className="chart-container">
                <Line data={moneyChartData} options={chartOptions} />
              </div>
            </div>

            {/* User Growth Stats - Line Chart */}
          

            {/* User Growth Stats - Doughnut Chart */}
            <div className="chart-wrapper">
              <h2 className="chart-title">User Growth Stats (Doughnut)</h2>
              <div className="chart-container">
                <Doughnut data={userDoughnutData} options={chartOptions} />
              </div>
            </div>
          </div>

          {/* Users Table */}
          <h2 className="user-table-title">All Users</h2>
          <table className="user-table">
            <thead>
              <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Email</th>
                <th>Spend</th>
                <th>Phone</th>
                <th>Actions</th>
              </tr>
            </thead>
            <tbody>
              {users.map(user => (
                <tr key={user.id}>
                  <td>{user.id}</td>
                  <td>{user.name}</td>
                  <td>{user.email}</td>
				  <td>{user.spend > 0 ? `$${user.spend}` : '$'}</td> {/* Display $ for spend of 0 */}
				  <td>{user.phone || 'null'}</td> {/* Show 'null' if phone is empty */}
                  <td>
                    <button
                      onClick={() => handleActionClick(user, 'edit')}
                      className="btn-edit"
                      disabled={false} /* Adjust based on your logic */
                    >
                      Edit
                    </button>
                    <button
                      onClick={() => handleActionClick(user, 'delete')}
                      className="btn-delete"
                      disabled={false} /* Adjust based on your logic */
                    >
                      Delete
                    </button>
                  </td>
                </tr>
              ))}
            </tbody>
          </table>

          {/* Modal for Edit/Delete Actions */}
          {isModalOpen && selectedUser && (
            <>
              <div className="modal-overlay" onClick={closeModal}></div>
              <div className="modal">
                <div className="modal-content">
                  {actionType === 'edit' ? (
                    <form onSubmit={handleEditSubmit}>
                      <label htmlFor="name">Name:</label>
                      <input
                        id="name"
                        type="text"
                        value={editForm.name}
                        onChange={(e) => setEditForm({ ...editForm, name: e.target.value })}
                        required
                      />
<br/>
                      <label htmlFor="email">Email:</label>
                      <input
                        id="email"
                        type="email"
                        value={editForm.email}
                        onChange={(e) => setEditForm({ ...editForm, email: e.target.value })}
                        required
                      />

                      <div className="modal-buttons">
                        <button type="submit" className="btn-edit">Save Changes</button>
                        <button type="button" className="btn-close" onClick={closeModal}>Cancel</button>
                      </div>
                    </form>
                  ) : (
                    <>
                      <p>Are you sure you want to delete user "{selectedUser.name}"?</p>
                      <div className="modal-buttons">
                        <button onClick={handleDeleteConfirm} className="btn-delete">Confirm Delete</button>
                        <button className="btn-close" onClick={closeModal}>Cancel</button>
                      </div>
                    </>
                  )}
                </div>
              </div>
            </>
          )}
        </>
      )}
    </div>
  );
};

export default AdminPage;

// src/pages/Dashboard.tsx
import React, { useEffect } from 'react';
import { useNavigate } from 'react-router-dom';

const Dashboard: React.FC = () => {
  const navigate = useNavigate();

  useEffect(() => {
    const isLoggedIn = localStorage.getItem('isLoggedIn') === 'true';
    if (!isLoggedIn) {
      navigate('/login');
    }
  }, [navigate]);

  const handleLogout = () => {
    localStorage.removeItem('isLoggedIn');
    localStorage.removeItem('userId');
	window.location.reload();
  };

  return (
    <div className="dashboard">
      <h1>Dashboard</h1>
      <p>Witaj w panelu użytkownika!</p>
      <button onClick={handleLogout}>Wyloguj się</button>
    </div>
  );
};

export default Dashboard;
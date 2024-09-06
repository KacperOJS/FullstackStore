import React from 'react';
import { Navigate, Outlet } from 'react-router-dom';

const ProtectedRoute: React.FC = () => {
  const isLoggedIn = localStorage.getItem('isLoggedIn') === 'true';

  if (!isLoggedIn) {
    // Jeśli użytkownik nie jest zalogowany, przekieruj go na stronę główną
    return <Navigate to="/" replace />;
  }

  // Jeśli użytkownik jest zalogowany, renderuj chroniony komponent
  return <Outlet />;
};

export default ProtectedRoute;
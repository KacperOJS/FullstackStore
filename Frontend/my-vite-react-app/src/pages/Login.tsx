import React, { useState } from "react";
import { Link, useNavigate } from "react-router-dom";
import "../styles/Login.css";

interface LoginResponse {
  message: string;
  userId?: number;
  customerName?: string;
  
}

const Login = () => {
  const [form, setForm] = useState({
    email: "",
    password: "",
  });
  const [error, setError] = useState<string | null>(null);
  const navigate = useNavigate();

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    setError(null);
    try {
      const response = await fetch("http://localhost:5250/api/Customer/login", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(form),
      });

      const data: LoginResponse = await response.json();

      if (!response.ok) {
        throw new Error(data.message || `HTTP error! status: ${response.status}`);
      }

      console.log("Logowanie udane:", data);
   
	  
      // Save login info in localStorage
      localStorage.setItem('isLoggedIn', 'true');
      if (data.userId) {
        localStorage.setItem('userId', data.userId.toString());
      }
	  if(data.customerName){
		localStorage.setItem('username',data.customerName)
	  }

      // Redirect to home page after successful login
      navigate('/dashboard');
    } catch (error) {
      if (error instanceof Error) {
        setError(error.message);
      } else {
        setError("Wystąpił nieznany błąd podczas logowania");
      }
      console.error("Błąd podczas logowania:", error);
    }
  };

  return (
    <div className="login-page-container">
      <div className="login-page-form">
        <h2 className="login-page-title">Zaloguj się</h2>
        {error && <p className="error-message">{error}</p>}
        <form onSubmit={handleSubmit}>
          <div className="login-form-group">
            <input
              type="email"
              placeholder="Adres e-mail"
              value={form.email}
              onChange={(e) => setForm({ ...form, email: e.target.value })}
              required
            />
          </div>
          <div className="login-form-group">
            <input
              type="password"
              placeholder="Hasło"
              value={form.password}
              onChange={(e) => setForm({ ...form, password: e.target.value })}
              required
            />
          </div>
          <button type="submit" className="login-submit-button">
            Zaloguj się
          </button>
        </form>
        <p className="login-register-link">
          Nie masz konta? <Link to="/register">Zarejestruj się</Link>
        </p>
        <p className="login-home-link">
          lub wróć do <Link to="/">Strony głównej</Link>
        </p>
      </div>
    </div>
  );
};

export default Login;

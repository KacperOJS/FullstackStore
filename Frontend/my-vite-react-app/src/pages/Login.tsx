import React, { useState } from "react";
import { Link, useNavigate } from "react-router-dom";
import "../styles/Login.css";
import Cookies from 'js-cookie';
const Login = () => {
  const [form, setForm] = useState({
    email: "",
    password: "",
  });

  const navigate = useNavigate();

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    try {
      const response = await fetch("http://localhost:5250/api/Customer/login", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(form)
      });

      if (!response.ok) {
        throw new Error(`HTTP error! status: ${response.status}`);
      }

      const data = await response.json();
      alert("Logowanie udane");
      console.log("Logowanie udane:", data);
      
	  Cookies.set('token', data.token, { expires: 7, secure: true, sameSite: 'strict' });
	  alert("Logowanie udane");
      console.log("Token otrzymany i zapisany w cookies");
      
      // Przekierowanie na stronę główną po udanym logowaniu
      navigate('/');
    } catch (error) {
      alert("Błąd podczas logowania. Sprawdź swoje dane.");
      console.error("Błąd podczas logowania:", error);
    }
  };

  return (
    <div className="login-page-container">
      <div className="login-page-form">
        <h2 className="login-page-title">Zaloguj się</h2>
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
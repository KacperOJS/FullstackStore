import  { useState } from "react";
import { Link, useNavigate } from "react-router-dom";
import "../styles/Register.css";

const Register = () => {
	const navigate = useNavigate();
	  // State for daily payment totals
	  const baseUrl = process.env.REACT_APP_BASE_URL || 'http://141.144.237.34:5250'; // Fallback to localhost if not set
  const [form, setForm] = useState({
    name: "",
    email: "",
    password: "",
  });

  const handleSubmit = async (e: React.FormEvent) => {
	e.preventDefault();
	try {
	  const response = await fetch(`${baseUrl}/api/Customer`, {
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
	  alert("Rejestracja udana");
	  navigate("/login", { replace: true });
	  console.log("Rejestracja udana:", data);
	 
	} catch (error) {
	  alert("Błąd podczas rejestracji/Nazwa użytkownika lub email jest już zajęty");
	  console.error("Błąd podczas rejestracji:", error);
	 
	}
  };

  return (
    <div className="register-page-container">
      <div className="register-page-form">
        <h2 className="register-page-title">Utwórz konto</h2>
        <form onSubmit={handleSubmit}>
          <div className="register-form-group">
            <input
              type="text"
              placeholder="Imię i nazwisko"
              value={form.name}
              onChange={(e) => setForm({ ...form, name: e.target.value })}
              required
            />
          </div>
          <div className="register-form-group">
            <input
              type="email"
              placeholder="Adres e-mail"
              value={form.email}
              onChange={(e) => setForm({ ...form, email: e.target.value })}
              required
            />
          </div>
          <div className="register-form-group">
            <input
              type="password"
              placeholder="Hasło"
              value={form.password}
              onChange={(e) => setForm({ ...form, password: e.target.value })}
              required
            />
          </div>
          <button type="submit" className="register-submit-button">
            Zarejestruj się
          </button>
        </form>
        <p className="register-login-link">
          Masz już konto? <Link to="/login">Zaloguj się</Link>
        </p>
        <p className="register-home-link">
          lub wróć do <Link to="/">Strony głównej</Link>
        </p>
      </div>
    </div>
  );
};

export default Register;
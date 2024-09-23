import React, { useEffect, useState } from 'react';
import '../styles/Contact.css'; // Import styles

const Contact: React.FC = () => {
  const [formData, setFormData] = useState({ name: '', email: '', message: '' });
  const [submitted, setSubmitted] = useState(false);
  const [error, setError] = useState('');

  // Check if the user is logged in and get user information from local storage
  const isLoggedIn = localStorage.getItem('isLoggedIn') === 'true';
  const username = localStorage.getItem('username') || '';
  const userMail = localStorage.getItem('email') || '';

  useEffect(() => {
    // If logged in, set the name and email fields and disable the name field
    if (isLoggedIn) {
      setFormData({ name: username, email: userMail, message: '' });
    }
  }, [isLoggedIn, username, userMail]); // Add userMail as a dependency
  
  const handleChange = (e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
    setFormData({ ...formData, [e.target.name]: e.target.value });
  };

  const handleSubmit = (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    if (!formData.name || !formData.email || !formData.message) {
      setError('All fields are required!');
      return;
    }

    // Simulate form submission
    console.log('Form submitted:', formData);
    setSubmitted(true);
    setError('');
    setFormData({ name: '', email: '', message: '' });
  };

  return (
    <div className="contact-container">
      <h1 className="contact-title">Contact Us</h1>
      <p className="contact-description">
        We're here to help! Fill out the form below, and we will get back to you as soon as possible.
      </p>
      
      {submitted ? (
        <div className="success-message">
          <h2>Thank you for reaching out!</h2>
          <p>Your message has been sent. We will get back to you soon!</p>
        </div>
      ) : (
        <form onSubmit={handleSubmit} className="contact-form">
          {error && <p className="error-message">{error}</p>}
          
          <div className="form-group">
            <label htmlFor="name">Name:</label>
            <input
              type="text"
              id="name"
              name="name"
              value={formData.name}
              onChange={handleChange}
              required
              className="form-input"
			  disabled={isLoggedIn} // Disable if logged in
            />
          </div>

          <div className="form-group">
            <label htmlFor="email">Email:</label>
            <input
              type="email"
              id="email"
              name="email"
              value={formData.email}
              onChange={handleChange}
              required
              className="form-input"
			  disabled={isLoggedIn} // Disable if logged in
            />
          </div>

          <div className="form-group">
            <label htmlFor="message">Message:</label>
            <textarea
              id="message"
              name="message"
              value={formData.message}
              onChange={handleChange}
              required
              className="form-textarea"
            ></textarea>
          </div>

          <button type="submit" className="form-submit">Send Message</button>
        </form>
      )}

      <div className="contact-info">
        <h2>Contact Information</h2>
        <p>Email: support@example.com</p>
        <p>Phone: +1 (123) 456-7890</p>
      </div>

      <div className="faq-section">
        <h2>Frequently Asked Questions</h2>
        <div className="faq-item">
          <h3>What is your return policy?</h3>
          <p>We accept returns within 30 days of purchase. Please contact us for more details.</p>
        </div>
        <div className="faq-item">
          <h3>How can I track my order?</h3>
          <p>You will receive an email with tracking information once your order is shipped.</p>
        </div>
        <div className="faq-item">
          <h3>Do you offer international shipping?</h3>
          <p>Yes, we ship to many countries worldwide. Please check our shipping policy for more information.</p>
        </div>
      </div>

      <div className="social-media">
        <h2>Follow Us</h2>
        <a href="https://www.facebook.com" className="social-link">Facebook</a>
        <a href="https://www.twitter.com" className="social-link">Twitter</a>
        <a href="https://www.instagram.com" className="social-link">Instagram</a>
      </div>
    </div>
  );
};

export default Contact;

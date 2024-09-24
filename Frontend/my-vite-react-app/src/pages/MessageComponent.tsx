import { useEffect, useState } from 'react';
import '../styles/MessageComponent.css';

interface Message {
  id: number;
  name: string; // Sender's name
  email: string; // Sender's email
  message: string; // Content of the message
}

const MessageComponent = () => {
  const [messages, setMessages] = useState<Message[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  // Fetch messages from the API
  useEffect(() => {
    const fetchMessages = async () => {
      try {
        const response = await fetch('http://localhost:5250/api/Contact');
        if (!response.ok) throw new Error('Network response was not ok');
        const data = await response.json();
        setMessages(data);
      } catch (error: any) {
        setError(error.message);
      } finally {
        setLoading(false);
      }
    };

    fetchMessages();
  }, []);

  // Delete a message by ID
  const deleteMessage = async (id: number) => {
    try {
      const response = await fetch(`http://localhost:5250/api/Contact/${id}`, {
        method: 'DELETE',
      });
      if (!response.ok) throw new Error('Failed to delete message');
      setMessages(messages.filter((message) => message.id !== id));
    } catch (error: any) {
      setError(error.message);
    }
  };

  return (
    <div className="message-component">
      {loading && <p className="loading">Loading messages...</p>}
      {error && <p className="error">{error}</p>}
      {messages.length === 0 && !loading && <p>No messages found.</p>}
      <div className="messages-container">
        {messages.map((msg) => (
          <div className="message" key={msg.id}>
            <div className="message-header">
              <span className="message-sender">{msg.name}</span>
              <span className="message-email">{msg.email}</span>
            </div>
            <p className="message-content">{msg.message}</p>
            <div className="message-actions">
              <button className="delete-button" onClick={() => deleteMessage(msg.id)}>Delete</button>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
};

export default MessageComponent;

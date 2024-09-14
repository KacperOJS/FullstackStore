import  { useState } from 'react';
import '../styles/EditModal.css';

interface EditModalProps {
  currentDetails: any;
  onClose: () => void;
  onUpdate: (updatedDetails: any) => void;
}

const EditModal: React.FC<EditModalProps> = ({ currentDetails, onClose, onUpdate }) => {
  const [username, setUsername] = useState(currentDetails.name || '');
  const [email, setEmail] = useState(currentDetails.email || '');

  const handleSubmit = (event: React.FormEvent) => {
    event.preventDefault();
    onUpdate({ username, email });
  };

  return (
    <div className="edit-modal-overlay">
      <div className="edit-modal-content">
        <h2>Edit Profile</h2>
        <form onSubmit={handleSubmit}>
          <label>
            Name:
            <input 
              type="text" 
              value={username} 
              onChange={(e) => setUsername(e.target.value)} 
              required 
            />
          </label>
          <label>
            Email:
            <input 
              type="email" 
              value={email} 
              onChange={(e) => setEmail(e.target.value)} 
              required 
            />
          </label>
          <div className="modal-buttons">
            <button type="submit">Save</button>
            <button type="button" onClick={onClose}>Cancel</button>
          </div>
        </form>
      </div>
    </div>
  );
};

export default EditModal;

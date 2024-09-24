import { useState } from 'react';
import '../styles/faq.css';

interface FAQItem {
  question: string;
  answer: string;
}

const FAQComponent = () => {
  const [activeIndex, setActiveIndex] = useState<number | null>(null);

  // FAQ data
  const faqData: FAQItem[] = [
    {
      question: 'What is your return policy?',
      answer: 'You can return any item within 30 days of purchase as long as it is in its original condition and packaging. Just contact our support for further details.',
    },
    {
      question: 'How long does shipping take?',
      answer: 'Shipping typically takes between 3-7 business days depending on your location. We also offer expedited shipping options.',
    },
    {
      question: 'Do you ship internationally?',
      answer: 'Yes, we offer international shipping to most countries. Please check the shipping options at checkout for more details.',
    },
    {
      question: 'Can I change my order after placing it?',
      answer: 'Yes, you can modify your order if it hasn’t been processed yet. Contact our customer service as soon as possible to make changes.',
    },
    {
      question: 'How do I track my order?',
      answer: 'Once your order is shipped, you will receive an email with a tracking number. Use that number on our website or the courier’s site to track your package.',
    },
    {
      question: 'What payment methods do you accept?',
      answer: 'We accept major credit cards, PayPal, Apple Pay, and Google Pay. You can choose your preferred method at checkout.',
    },
    {
      question: 'How do I create an account?',
      answer: 'To create an account, click on the "Sign Up" button on the top-right corner of the page and fill in your personal details. An activation email will be sent to your inbox.',
    },
    {
      question: 'Can I reset my password?',
      answer: 'Yes, you can reset your password by clicking "Forgot Password" on the login page. A password reset link will be sent to your registered email.',
    },
    {
      question: 'Do you offer gift cards?',
      answer: 'Yes, we offer both physical and digital gift cards. You can purchase them from our "Gift Cards" section.',
    },
    {
      question: 'How do I contact customer service?',
      answer: 'You can contact our customer service via email at support@example.com or call us at (123) 456-7890 during business hours.',
    },
    {
      question: 'What should I do if I received a defective item?',
      answer: 'If you received a defective item, please contact our customer service immediately with your order details, and we will arrange for a replacement or refund.',
    },
    {
      question: 'Is my personal information secure?',
      answer: 'Yes, we take your privacy seriously and use advanced encryption methods to ensure that your personal information is protected.',
    },
    {
      question: 'Can I cancel my subscription?',
      answer: 'Yes, you can cancel your subscription at any time from your account settings. You will continue to have access until the end of your current billing period.',
    },
  ];

  // Toggle active FAQ
  const toggleFAQ = (index: number) => {
    setActiveIndex(activeIndex === index ? null : index);
  };

  return (
    <div className="faq-container">
      <h1 className="faq-title">Frequently Asked Questions</h1>
      <div className="faq-list">
        {faqData.map((item, index) => (
          <div className="faq-item" key={index}>
            <div
              className={`faq-question ${activeIndex === index ? 'active' : ''}`}
              onClick={() => toggleFAQ(index)}
            >
              <span>{item.question}</span>
              <span className="faq-toggle-icon">
                {activeIndex === index ? '-' : '+'}
              </span>
            </div>
            <div
              className={`faq-answer ${activeIndex === index ? 'show' : 'hide'}`}
            >
              <p>{item.answer}</p>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
};

export default FAQComponent;

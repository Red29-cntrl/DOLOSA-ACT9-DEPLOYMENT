CREATE DATABASE IF NOT EXISTS my_app_db;
USE my_app_db;

CREATE TABLE IF NOT EXISTS users (
  id INT AUTO_INCREMENT PRIMARY KEY,
  username VARCHAR(50),
  password VARCHAR(255),
  email VARCHAR(100)
);

CREATE TABLE IF NOT EXISTS transaction_types (
  transaction_type VARCHAR(50) PRIMARY KEY
);

CREATE TABLE IF NOT EXISTS transactions (
  transaction_id INT AUTO_INCREMENT PRIMARY KEY,
  user_id INT,
  transaction_type VARCHAR(50),
  amount DECIMAL(10,2),
  created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  FOREIGN KEY (user_id) REFERENCES users(id),
  FOREIGN KEY (transaction_type) REFERENCES transaction_types(transaction_type)
);
-- Insert default transaction types
INSERT IGNORE INTO transaction_types VALUES ('Deposit'), ('Withdrawal');

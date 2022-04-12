CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';

CREATE TABLE IF NOT EXISTS contractors(
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  name TEXT NOT NULL
)default charset utf8 COMMENT '';

CREATE TABLE IF NOT EXISTS companies(
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  name TEXT NOT NULL,
  location TEXT
)default charset utf8 COMMENT '';

CREATE TABLE IF NOT EXISTS jobs(
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  contractorId INT NOT NULL,
  companyId INT NOT NULL,
  FOREIGN KEY (contractorId) REFERENCES contractors(id) ON DELETE CASCADE,
  FOREIGN KEY(companyId) REFERENCES companies(id) ON DELETE CASCADE
)default charset utf8 COMMENT '';

SELECT * FROM contractors;
SELECT * FROM companies;
SELECT * FROM jobs;
DROP TABLE IF EXISTS jobs;
INSERT INTO contractors
(name)
VALUES("Yo mamama");
INSERT INTO companies
(name, location)
VALUES ("Target", "Yeet Street");

INSERT INTO jobs
  (contractorId, companyId)
  VALUES (1, 2);

SELECT
con.*,
comp.*,
j.id AS jobId,
con.id AS contractorId,
comp.id AS companyId
FROM jobs j 
JOIN contractors con ON con.id = j.contractorId
JOIN companies comp ON comp.id = j.companyId
WHERE j.companyId = 1;


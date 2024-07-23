-- Create the table
CREATE TABLE Jokes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Joke NVARCHAR(255) NOT NULL,
    Punchline NVARCHAR(255) NOT NULL
);

-- Seed the table with jokes
INSERT INTO Jokes (Joke, Punchline) VALUES
('What is the most used language in programming?', 'Profanity.'),
('Why do Java programmers wear glasses?', 'Because they can''t C#.'),
('Why did the programmer quit their job?', 'Because they didn''t get arrays.'),
('What do you call a programmer who only codes in binary?', 'A bit of a nerd.'),
('What do you call .NET developers who like to knit?', 'StringBuilders'),
('Why do programmers always mix up Halloween and Christmas?', 'Because Oct 31 equals Dec 25.');
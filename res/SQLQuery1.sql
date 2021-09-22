CREATE TABLE Turmas (
	IDTurmas int IDENTITY(1,1) PRIMARY KEY,
	Turma varchar(10) NOT NULL,
);

CREATE TABLE Estatisticas(
	IDStats int IDENTITY(1,1) PRIMARY KEY,
	Acertos int,
	Falhas int,
	TestesAprovados int,
	TestesReprovados int,
);

CREATE TABLE Users(
	IDUsers int IDENTITY(1,1) PRIMARY KEY,
	Nome varchar(45) NOT NULL,
	Sobrenome varchar(45) NOT NULL,
	Email varchar(45) NOT NULL,
	Password varchar(100) NOT NULL,
	IDTurmas int FOREIGN KEY REFERENCES Turmas(IDTurmas),
	IDStats int FOREIGN KEY REFERENCES Estatisticas(IDStats),
);

CREATE TABLE Questoes(
	IDQuestoes int IDENTITY(1,1) PRIMARY KEY,
	Descricao varchar(255) NOT NULL,
	OA varchar(125) NOT NULL,
	OB varchar(125) NOT NULL,
	OC varchar(125) NOT NULL,
	OD varchar(125) NOT NULL,
	OCorreta varchar(125) NOT NULL,
);

CREATE TABLE Teste (
	IDTeste int IDENTITY(1,1) PRIMARY KEY,
	Titulo varchar(50) NOT NULL,
);

CREATE TABLE SetQuestaoToTeste(
	IDSet int IDENTITY(1,1) PRIMARY KEY,
	IDQuestoes int FOREIGN KEY REFERENCES Questoes(IDQuestoes),
	IDTeste int FOREIGN KEY REFERENCES Teste(IDTeste),
);
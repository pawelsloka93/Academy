CREATE TABLE Eventi (
idEventi  INT PRIMARY KEY IDENTITY (1,1),
nome VARCHAR(250) NOT NULL,
descrizione VARCHAR (250) NOT NULL,
dataEvento DATETIME,
luogo VARCHAR (250) NOT NULL,
capMax INT NOT NULL,
codiceEvento INT NOT NULL UNIQUE)


CREATE TABLE Risorse (
idRisorse INT PRIMARY KEY IDENTITY (1,1),
tipologia VARCHAR (250) NOT NULL,
quantità INT NOT NULL,
costo DECIMAL (5,2) NOT NULL,
fornitore VARCHAR (250) NOT NULL)


CREATE TABLE Partecipanti (
idPartecipanti INT PRIMARY KEY IDENTITY (1,1),
nome VARCHAR (250) NOT NULL,
cognome VARCHAR (250) NOT NULL,
codFis INT NOT NULL UNIQUE)




	CREATE TABLE Eventi_Partecipanti (
	eventiRIF INT NOT NULL ,
	partecipantiRIF INT NOT NULL,
	FOREIGN KEY (eventiRIF) REFERENCES eventi(idEventi),
	FOREIGN KEY (partecipantiRIF) REFERENCES Partecipanti(idPartecipanti),
	PRIMARY KEY (eventiRIF, partecipantiRIF)
	)


DROP TABLE IF EXISTS CorpoCeleste;
DROP TABLE IF EXISTS Sistema;
DROP TABLE IF EXISTS CorpoCeleste_Sistema;

CREATE TABLE CorpoCeleste (
corpoCelesteID INT PRIMARY KEY IDENTITY (1,1),
nomeCorpo VARCHAR (250) NOT NULL,
codiceCorpo VARCHAR(250) DEFAULT NEWID() NOT NULL,
dataScop DATETIME NOT NULL,
scopritore VARCHAR(250) DEFAULT 'SCONOSCIUTO',
tipologia VARCHAR(250) NOT NULL,
distanza DECIMAL (15,2) NOT NULL,
coordinataRadiale DECIMAL (15,2) NOT NULL,
coordinataAngolare DECIMAL (15,2) NOT NULL
);


CREATE TABLE Sistema (
sistemaID INT PRIMARY KEY IDENTITY (1,1),
nome VARCHAR(250) NOT NULL,
codiceSistema VARCHAR(250) DEFAULT NEWID() NOT NULL,
tipo VARCHAR (250) NOT NULL
);



CREATE TABLE CorpoCeleste_Sistema (
corpoCeleste_RIF INT NOT NULL,
sistema_RIF INT NOT NULL,
FOREIGN KEY (corpoCeleste_RIF) REFERENCES CorpoCeleste(corpoCelesteID),
FOREIGN KEY (sistema_RIF) REFERENCES Sistema(sistemaID),
PRIMARY KEY (corpoCeleste_RIF, sistema_RIF)
);














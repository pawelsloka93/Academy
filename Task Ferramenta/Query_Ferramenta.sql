
CREATE TABLE Prodotto (
prodottoId INT PRIMARY KEY IDENTITY (1,1),
codice VARCHAR (250) NOT NULL DEFAULT NEWID(),

nome VARCHAR (250) NOT NULL,
descrizione TEXT NOT NULL,
prezzo DECIMAL(10,2) NOT NULL CHECK (prezzo >0),
quantita INT NOT NULL,
categoria VARCHAR(250) NOT NULL UNIQUE,
dataCreazione DATETIME
)

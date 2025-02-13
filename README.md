# Aplicação Web

Sistema WebApi feito para testes e aprendizado.
Utilização de .Net 8.0 e Banco de dados SQLite.

## --- Modelos ---

### Pessoa

Script de criação da tabela
```
CREATE TABLE Pessoa (
	Id INTEGER NOT NULL,
	Sobrenome NVARCHAR NOT NULL,
	Nome NVARCHAR NOT NULL,
	DataNascimento DATETIME,
	Email NVARCHAR,
	CONSTRAINT PK_Employee PRIMARY KEY (Id)
);
```

Endpoints existentes:
- Resgatar todos os registros;
- Resgatar registro por Id;
- Adicionar registro;
- Atualizar registro;
- Deletar registro;

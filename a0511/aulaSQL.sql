--DDL
CREATE
ALTER
DROP

CREATE DATABASE AulaAtos;
DROP DATABASE AulaAtos;

CREATE TABLE ALUNOS
(
	ID INTEGER NOT NULL PRIMARY KEY IDENTITY,
	NOME VARCHAR(100) NOT NULL,
	CPF VARCHAR(11) NOT NULL,
	IDADE INTEGER
);

--PRIMARY KEY - chave primaria
--NULL e NOT NULL - campo nulo ou não nulo
--IDENTITY - auto incremento

DROP TABLE ALUNOS; -- exclui a tabela

ALTER TABLE ALUNOS 
ADD RG VARCHAR(12);

ALTER TABLE ALUNOS
DROP COLUMN IDADE;

ALTER TABLE ALUNOS 
ALTER COLUMN NOME VARCHAR(200) NOT NULL;

sp_rename 'ALUNOS.NOME', 'nome_completo', 'COLUMN';--RENOMEAR COLUNA

------------------------

CREATE TABLE CURSOS
(
	ID INTEGER NOT NULL PRIMARY KEY IDENTITY,
	NOME VARCHAR(30) NOT NULL,
	CARGA_HORARIA INTEGER NOT NULL,
	ATIVO BIT DEFAULT 1,
	DESCRICAO TEXT
)

CREATE TABLE DISCIPLINAS 
(
	ID INTEGER NOT NULL PRIMARY KEY IDENTITY,
	NOME VARCHAR(30) NOT NULL,
	CARGA_HORARIA INTEGER NOT NULL,
	FK_CURSO INTEGER NOT NULL,
	FOREIGN KEY (FK_CURSO) REFERENCES CURSOS(ID)
)

CREATE TABLE MATRICULAS
(
	ID INTEGER NOT NULL PRIMARY KEY IDENTITY,
	FK_ALUNO INTEGER NOT NULL,
	FK_CURSO INTEGER NOT NULL,
	FOREIGN KEY (FK_ALUNO) REFERENCES ALUNOS(ID),
	FOREIGN KEY(FK_CURSO) REFERENCES CURSOS(ID)
)

------------------------

--DML
INSERT
UPDATE
DELETE

--CRUD = CreateReadUpdateDelete
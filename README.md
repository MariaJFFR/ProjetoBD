# ProjetoBD — Sistema de Gestão de Nós e Clientes

![VB.NET](https://img.shields.io/badge/VB.NET-4.8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-2019-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-WinForms-0078D4?style=for-the-badge&logo=windows&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2017+-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white)

Aplicação desktop desenvolvida em **VB.NET / Windows Forms** para gestão de nós, tipos de nós e clientes finais, com base de dados **SQL Server** e acesso via stored procedures.

---

## Funcionalidades

- **Gestão de Clientes Finais** — criar, editar, consultar e eliminar clientes
- **Gestão de Nós** — criar, editar, consultar e eliminar nós associados a clientes
- **Tipos de Nó** — definir e gerir os tipos de nó disponíveis no sistema
- **Quadro Mestre-Detalhe** — visualizar os nós de um cliente num único ecrã integrado
- **Informação da Empresa** — ecrã inicial carregado dinamicamente a partir da base de dados
- **Validação de integridade referencial** — mensagens de erro claras ao tentar eliminar registos com dependências

---

## Estrutura do Projeto

```
ProjetoBD/
│
├── Classes/
│   ├── clsTIPONO.vb        # Acesso a dados — Tipos de Nó
│   ├── clsNO.vb            # Acesso a dados — Nós
│   ├── clsCLIENTEFINAL.vb  # Acesso a dados — Clientes Finais
│   └── clsPARI.vb          # Acesso a dados — Parâmetros / Empresa
│
├── Forms/
│   ├── Inicio.vb           # Ecrã inicial com info da empresa
│   ├── quadro.vb           # Quadro mestre-detalhe (Clientes + Nós)
│   ├── NoFixa.vb           # Ficha de Nó
│   ├── NoLista.vb          # Lista de Nós
│   ├── CFFixa.vb           # Ficha de Cliente Final
│   ├── CFLista.vb          # Lista de Clientes Finais
│   └── acercadefixe.vb     # Janela "Acerca de"
│
├── Modules/
│   └── Global.vb           # Connection string global
│
└── My Project/
    ├── AssemblyInfo.vb
    └── Settings.settings
```

---

## Modelo de Dados

```
┌─────────────┐        ┌────────────────┐        ┌──────────────┐
│   TIPONO    │        │      NO        │        │ CLIENTEFINAL │
│─────────────│        │────────────────│        │──────────────│
│ TN_COD (PK) │◄───────│ N_TN_Cod  (FK) │        │ CF_ID   (PK) │
│ TN_DESCR    │        │ N_COD     (PK) │        │ CF_Nome      │
└─────────────┘        │ N_CF_ID   (FK) │───────►│ CF_Valor     │
                       │ N_Valor        │        └──────────────┘
                       └────────────────┘

┌──────────┐
│  PARI    │   (parâmetros: nome, morada, NIF, telefone da empresa)
│──────────│
│ PI_Num   │
│ PI_Desc  │
│ PI_Val   │
└──────────┘
```

Todas as operações CRUD são feitas através de **stored procedures** no SQL Server.

---

## Pré-requisitos

| Requisito | Versão mínima |
|---|---|
| .NET Framework | 4.8 |
| Visual Studio | 2017 |
| SQL Server | 2019 (ou superior) |

---

## Configuração

1. **Restaurar a base de dados** no SQL Server com o nome `G07-T2-50596-50172`
2. **Criar os stored procedures** necessários (ver lista abaixo)
3. **Atualizar a connection string** em `Modules/Global.vb`:

```vb
Public DbCnnstr As String = "Data Source=<SERVIDOR>\<INSTANCIA>;Initial Catalog=G07-T2-50596-50172;Integrated Security=True"
```

4. Abrir `plojetofixe.sln` no Visual Studio e compilar

---

## Stored Procedures

| Tabela | Stored Procedures |
|---|---|
| TIPONO | `TIPONO_SELALL`, `TIPONO_SEL1`, `TIPONO_INS`, `TIPONO_UPD`, `TIPONO_DEL` |
| NO | `NO_SELLALL`, `NO_SELCF`, `NO_INS`, `NO_UPD`, `NO_DEL` |
| CLIENTEFINAL | `CLIENTEFINAL_SELALL`, `CLIENTEFINAL_SEL1`, `CLIENTEFINAL_INS`, `CLIENTEFINAL_UPD`, `CLIENTEFINAL_DEL` |
| PARI | `PARI_SEL1` |

---

## Arquitetura

- **Padrão de acesso a dados:** ADO.NET direto com `SqlClient` — sem ORM
- **Connection string centralizada:** módulo `Global.vb`
- **Eventos:** as classes de dados expõem eventos `Action` e `Errors` para comunicar resultados aos formulários
- **Sem dependências externas:** apenas bibliotecas do .NET Framework

---

## Versão

`1.4.2.0` — Desenvolvido em 2025 · Tangerina
# 🚀 Sistema de Notificações de Pedidos

## 📝 Descrição

Bem-vindo ao projeto de **Sistema de Notificações de Pedidos**! 🎉 Este sistema gerencia pedidos de clientes e envia notificações quando os estados dos pedidos são atualizados. O projeto é dividido em três APIs principais:

1. **PedidoAPI**: Gerencia a criação e o estado dos pedidos. 📦
2. **NotificacaoAPI**: Envia e gerencia notificações relacionadas aos pedidos. 📧📲
3. **EventosAPI**: Processa e publica eventos de mudança de estado dos pedidos. 📢

Utilizamos **Entity Framework** para o acesso a dados e **Hangfire** para gerenciar tarefas assíncronas.

## 🏗️ Estrutura do Projeto

### **1. PedidoAPI**

**Responsável pelo gerenciamento de pedidos.**

- **Pedido**: Representa um pedido com um identificador e status.
- **PedidoService**: Gerencia a criação e atualização de pedidos.
- **PedidoRepository**: Armazena e recupera pedidos.
- **PedidoFactory**: Cria instâncias de pedidos.
- **StatusPedido**: Enumeração para os possíveis estados dos pedidos.

### **2. NotificacaoAPI**

**Responsável pelo envio e gerenciamento de notificações.**

- **Notificacao**: Representa uma notificação com um identificador, tipo e conteúdo.
- **EnviadorDeNotificacao**: Envia notificações.
- **NotificacaoRepository**: Armazena e recupera notificações pendentes.
- **NotificacaoFactory**: Cria instâncias de notificações.
- **TipoNotificacao**: Enumeração para os tipos de notificações (e-mail, SMS).

### **3. EventosAPI**

**Responsável por processar e publicar eventos relacionados ao pedido.**

- **PublicadorDeEventos**: Publica eventos de mudança de estado dos pedidos.
- **EventoMudancaStatusPedido**: Representa um evento de mudança de status de pedido.
- **ProcessadorDeNotificacao**: Processa eventos e aciona o envio de notificações.

## 📡 Eventos e Comunicação

Os eventos são utilizados para a comunicação entre os microserviços. Quando um pedido é criado ou seu estado é atualizado, um evento é publicado e processado pelo **EventosAPI**, que então aciona o **NotificacaoAPI** para enviar notificações ao cliente.

## 🛠️ Tecnologias e Padrões

- **.NET Core**: Framework para implementar os microserviços. 💻
- **Entity Framework**: ORM para acesso a dados. 🗄️
- **Hangfire**: Gerencia o envio de notificações de forma assíncrona. ⏳
- **Padrões Criacionais**: Padrão Factory para criação de pedidos e notificações. 🔧
- **Arquitetura de Microserviços**: Microserviços independentes comunicando-se via eventos ou mensagens. 🌐

## 📥 Instalação

### Requisitos

- **.NET Core SDK** 🛠️
- **SQL Server** (ou outro banco de dados compatível) 🗃️

### EM CONSTRUÇÃO

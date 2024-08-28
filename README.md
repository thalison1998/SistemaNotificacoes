# 🚀 Sistema de Notificações de Pedidos

## 📝 Descrição

Bem-vindo ao projeto de **Sistema de Notificações de Pedidos**! 🎉 Este é um sistema em construção que gerencia pedidos de clientes e envia notificações quando os estados dos pedidos são atualizados. O sistema é dividido em dois microserviços principais:

- **PedidoService**: Gerencia a criação e o estado dos pedidos. 📦
- **NotificationService**: Envia notificações (e-mail, SMS, etc.) quando o estado do pedido é alterado. 📧📲

Utilizamos **Entity Framework** para o acesso a dados e **Hangfire** para gerenciar tarefas assíncronas.

## 🚀 Funcionalidades

- **Criar Pedido**: Permite criar pedidos através da API do PedidoService. ✍️
- **Atualizar Estado do Pedido**: Atualiza o estado do pedido e envia um evento para o NotificationService. 🔄
- **Enviar Notificação**: O NotificationService envia uma notificação ao cliente quando o estado do pedido muda. 📬

## 🏗️ Estrutura do Projeto

### PedidoService

- **PedidoController**: Endpoint para criar e atualizar pedidos. 🛠️
- **PedidoRepository**: Armazena pedidos (em memória ou SQLite). 🗃️
- **PedidoFactory**: Usa o padrão Factory para criar instâncias de pedidos. 🏭
- **EventPublisher**: Publica eventos de mudança de estado dos pedidos para o NotificationService. 📢

### NotificationService

- **NotificationProcessor**: Processa eventos e agenda notificações. ⏲️
- **NotificationRepository**: Armazena notificações pendentes (em memória ou SQLite). 📑
- **NotificationSender**: Envia notificações (e-mail/SMS) usando Hangfire para gerenciamento assíncrono. 📤
- **NotificationFactory**: Usa o padrão Factory para criar diferentes tipos de notificações (e-mail, SMS). 🏷️

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

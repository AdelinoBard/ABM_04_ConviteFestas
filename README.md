## ABM_ConviteFestas

Aplicativo de Confirmação de Presença em um evento, festa ou algo do tipo.

1. Página inicial com informações sobre a festa
2. Formulário de confirmação de presença (RSVP)
3. Validação do formulário e página de agradecimento
4. Página de resumo com lista de confirmados

## Pré-requisitos
- SDK .NET 9.0.203
```bash
dotnet --version
```

## Testando o Aplicativo
1. Execute o projeto:
```bash
dotnet run
```
2. Acesse: http://localhost:5000
3. Teste o fluxo completo:
   - Página inicial → Formulário → Confirmação → Lista de confirmados

## Melhorias Futuras
- Adicionar autenticação de usuários
- Implementar armazenamento persistente (banco de dados)
- Adicionar upload de fotos para a página inicial
- Implementar envio de e-mails de confirmação
```

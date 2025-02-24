# CreditSuisse.TradeCategory

RESPOSTAS DO TESTE: 

1- Segue implementação do projeto utilizando a classe abstrata TradeCategory pra gerar vários tipos de categorias diferentes que poderão ser extendidas futuramente caso seja necessária a criação de novas categorias. 

2- Para adicionar uma nova categoria de PEP será necessários adicionar a nova propriedade `IsPoliticallyExposed` na interface `ITrade` e na classe `Trade`, depois precisaremos criar uma nova classe `PoliticallyExposedCategory` que herde `TradeCategory` e então implementar essa classe com `Name => "PEP"` e o método `IsMatch` com `trade.IsPoliticallyExposed == true` e por último devemos adicionar essa nova categoria no array `categories` da classe `TradeCategorizer` (pelo meu entendimento do caso de uso na segunda posição da lista).

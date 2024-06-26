﻿#  Yet Another Dungeon Crawler
Este projeto foi criado como solução do projeto 2 de Linguagens de Programação 2023/2024.

Yet Another Dungeon Crawler é um jogo para um jogador, feito em C# 8.0 e compatível com Windows, macOS e Linux. O projeto consiste de um *dungeon crawler*, um tipo de jogo onde o jogador entra numa masmorra e ao enfrentar os perigos que a mesma contem, tenta sobreviver e escapar os horrores desta masmorra.

## Objetivo
O objetivo final do jogador é chegar ao fim da masmorra vivo e fugir da mesma. Pelo caminho o mesmo terá de explorar diferentes quartos, descobrir itens e enfrentar inimigos.

![Map Layout and Description of icons](https://cdn.discordapp.com/attachments/1243543551271374908/1244260121211703369/Map_1.png?ex=6654770a&is=6653258a&hm=2446fc60077dd938d3b4b173dae458cd65b53dad5773c67cb7763ef4bc13aff9&)

## Regras do Jogo
O jogador pode: 
[Attack] - Atacar o inimigo; 
[Move] - Mover-se numa direção; 
[Pick_Up] - Apanhar itens; 
[Use] - Usar itens que ele tenha no inventário; 
[Iventory] - Aceder o seu inventário; 
[Health] - Ver a sua vida. 
As ações que requerem a interação do jogador com o ambiente ou um item tem de especificar o que quer interagir, ex: [Pick Up Potion] - O jogador apanha a poção.

O jogador ao entrar numa sala e se conter um inimigo, ele só pode agir com o resto da sala após eliminar o inimigo. 
O jogo acaba quando o jogador ou chega ao fim e escapa com sucesso ou quando a sua vida chega a 0 e morre.

# Autoria

- André Sebastião a22008519
- António Sotto-Mayor a22007432
- Diogo Freire a22104684

## Distribuição de Tarefas
**André Sebastião**
 - Criação do documento README.md.
 - Implementação e integração dos diferentes elementos e fluxogramas no documento README.md.
 - Criação do Game Design do jogo (Variavéis e Valores).
 - Descrição das salas e itens.
 - Criação da introdução do jogo ao jogador.
 - Controlador MVC.
 
**António Sotto-Mayor**
- Lógica do Player.
- Lógica do Inimigo.
- Criação do mapa.
- Sistema de deteção do player.
- Sistema das salas e mapa do jogo.
- Resolução de bugs.

**Diogo Freire**
- MVC Inicial.
- Deteção do ficheiro de texto.
- Failsafe system.
- Interfaces ICharacter e IView.
- Lógica de Itens.
- Lógica do Player.
- Resolução de bugs.

# Arquitetura da Solução
Como requerimento do projeto, o programa deve funcionar em Windows, macOS e Linux, impedindo a utilização de alguns métodos incompatíveis com outras plataformas. O programa também necessitava da implementação de um sistema MVC - Model, View and Controller para uma boa organização do mesmo.
O primeiro problema encontrado no projeto foi a geração do mapa com os parâmetros necessários. De momento, o código está feito de maneira a aceitar um mapa de qualquer tamanho, mas para propósitos deste exercício, o mapa é de 6x6. 
Foi criado 2 array bidimensionais para expressar o mapa e o jogador a interagir com o mesmo. O primeiro foi criado com base nos parâmetros definidos e descrições das salas, que neste momento estão todos definidos num .txt que contem a informação toda das salas. O segundo array é necessário para o movimento e localização do jogador, isto sendo feito desta maneira, pois fazer tudo no primeiro array necessitava a leitura e edição do ficheiro .txt, desta maneira temos 2 array que funcionam como guia um do outro, comparando valores do índex para manter a informação coerente.
Após ter a geração do nível feito, o que faltava era popular o mapa. O Player e Enemy ambos herdam informação de uma interface ICharacters que contem os parâmetros em comum para qualquer habitante desta masmorra. 
Tudo isto foi feito em conta o sistema MVC, mantendo a lógica no Model, a informação dada e recebida do jogador no View e a interpretação dos inputs e game loop no Controller.

## Diagrama UML
```mermaid

classDiagram

    Model       <--     Program
    
    Controller  <--     Program

    View        <--     Program
    View        <--     Controller
    View        <--     Model
    
    IView       <|..    View

    Player      <--     Controller
    Player      <--     Model

    Item        --*     Player
    Item        <|--    HealthPotion

    ICharacter  <|..    Player
    ICharacter  <|..    Enemy

    Map         <--     Controller
    Map         <--     Model

    class Item
    <<abstract>>    Item

    class ICharacter 
    <<interface>>   ICharacter 

    class IView
    <<interface>>   IView 
```

# Referências
- [1]  Whitaker, R. B. (2022). **The C# Player's Guide** (5th Edition). Starbound Software.
- [2] Albahari, J., & Johannsen, E. (2020). **C# 8.0 in a Nutshell**. O'Reilly Media.
- [3] Dorsey, T. (2017). **Doing Visual Studio nad .NET Code Documentation Right**. Visual Studio Magazine. Retrieced from https://visualstudiomagazine.com/articles/2017/02/21/vs-dotnet-code-documentation-tools-roundup.aspx






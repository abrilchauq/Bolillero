## Documentacion

```mermaid
classDiagram
    class Bolillero{
        +cantidad: int 
        +nroBolillas: List int
        +Jugadas: List
        +JugarNVeces: 
        +SacarBolilla() int
    }

    class IAzar{
        <<interface>>
        +SacarBolilla()
    }

    class AzarR{
        +
    }


AzarR ..|> IAzar
Bolillero --|> IAzar

```
## Documentacion

```mermaid
classDiagram
    class Bolillero{
        +Bolillas List~int~ int
        +Afuera List~int~ int 
        +Azar IAzar
        +Jugar (List~int~) bool 
        +JugarNVeces (List~int~) int
        +SacarBolilla()
        +MeterBolilla()
        +CrearBolilla()
    }

    class IAzar{
        <<interface>>
        +IndiceAleatorio(List~int~): int 
    }

    class AzarRandom{
        +IndiceAleatorio(List~int~): int 
    }

    class ElegirPrimera{
        +IndiceAleatorio(List~int~): int
    }


AzarRandom ..|> IAzar
ElegirPrimera ..|> IAzar
Bolillero --> IAzar

```
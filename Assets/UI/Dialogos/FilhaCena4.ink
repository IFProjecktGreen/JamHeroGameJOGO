INCLUDE global.ink

#Carla

{chefe == "false": -> filha1 | -> filha2}

=== filha1 ===
Oi papai
    *[Gostou do lugar filha?]
        É, ele é bem grande mesmo
            **[Aproveita bastante a festa, o papai vai só falar com os amigos dele, eu ja volto]
                -> DONE
    *[Aqui pode não ser o parque, mas também é divertido]
        Muito divertido... Igual um parque...
            **[Mostra o seu ursinho para as outras crianças, elas vão adorar.]
                ta bom
                    ***[Muito bem filhota. Papai ja volta, vou só ali falar com meus colegas]
                        Ok
                            -> DONE
                        
=== filha2 ===
Papai, você ta bem?
    *[ESTOU ÓTIMO FILHA!!!]
        ...
        A mamãe quer falar com o senhor
            ->DONE
    *[Só um pouco tonto, mas nada de mais]
        Papai... Nada
        ->DONE
        


-> END
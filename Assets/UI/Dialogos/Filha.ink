INCLUDE global.ink
#Carla

{filha_urso == "true": -> fim}
{urso == "true" && crianca_1 == "true": -> crianca_urso}
{crianca_1 == "false": -> crianca | -> chorinho}



=== crianca ===

PAPAI! PAPAI! VOCÊ CHEGOU!  
Ja decidiu para onde vamos amanhã? 
Estou muito ansiosa para o meu aniversário.
    *[Carla, não poderemos comemorar amanhã. Haverá um evento do trabalho.]
        -> choro
    *[Querida, infelizmente papai estará ocupado.]
        -> choro
        
  
    === choro ===
MAS O SENHOR PROMETEU QUE IRÍAMOS COMEMORAR ESSE ANO
SEMPRE É A MESMA COISA.
NEM PRESENTE EU GANHO MAIS.
(Carla começa a chorar)
~ crianca_1 = "true"
    -> DONE

=== crianca_urso ===
(Snif Snif)
    ~ filha_urso = "true"
    *[Querida, não poderemos ir ao parque amanhã, mas nós podemos comemorar na festa que o papai vai amanhã]
        Mas eu queria muito ir para o parque
        eu, eu... Tudo bem
            **[Você vai gostar, tenho certeza. Toma esse ursinho que eu comprei pra você]
                Obrigado pai...
                ~ urso = "false"
                    ->DONE
            **[Olha esse ursinho que o papai comprou para você]
                Que fofinho, obrigado pai
                ~ urso = "false"
                    ->DONE
    *[Filha, papai lembrava, até comprei esse ursinho]
        Obrigada...
        ->DONE
        
=== chorinho ===
(Snif Snif)
    -> DONE

=== fim ===
Boa noite, vou dormir
~fim_cena1 = "true"
    -> DONE

-> END
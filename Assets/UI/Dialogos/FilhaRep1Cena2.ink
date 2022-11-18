INCLUDE global.ink

#Carla

{crianca_1Triste == "true": -> chorinho}
{crianca_1 == "false": -> crianca}
{crianca_1Triste == "false": -> UrsoBom}


=== crianca ===

PAPAI! PAPAI! VOCÊ CHEGOU!  
Ja decidiu para onde vamos amanhã? 
Estou muito ansiosa para o meu aniversário.
    *[Carla, não poderemos comemorar amanhã. Haverá um evento do trabalho.]
        -> choro
    *[Querida... Nós vamos para o parque!!!]
        -> felicidade
  
=== choro ===
MAS VOCÊ PROMETEU QUE IRÍAMOS COMEMORAR ESSE ANO
SEMPRE É A MESMA COISA.
NEM PRESENTE VOCÊ ME DA, SEMPRE O TRABALHO.
(Carla começa a chorar)
~ crianca_1Triste = "true"
~ crianca_1 = "true"
    -> DONE
    
=== chorinho ===
(snif snif)
{urso == "true": -> crianca_urso}
    ->DONE
    
    
=== felicidade ===
PAPAI, EU TE AMO MUITO!!!!!
ORBIGADA PAPAI
eu pensei...(snif)
pensei que você ia deixar para lá como todo ano
mas eu sabia, sabia que você não ia fazer mais isso
MAMÃE NÓS VAMOS PARA O PARQUE AMANHÃ
~ crianca_1Triste = "false"
~ crianca_1 = "true"
    -> DONE

=== crianca_urso ===
(Snif Snif)
Você quer dar o urso?
    *[Sim]
    ~filha_urso = "true"
        **[Querida, não poderemos ir ao parque amanhã, mas nós podemos comemorar na festa que o papai vai amanhã]
            Mas eu queria muito ir para o parque
            eu, eu... Tudo bem
                ***[Você vai gostar, tenho certeza. Toma esse ursinho que eu comprei pra você]
                    Obrigado pai
                    ~ urso = "false"
                    ~ crianca_1Triste = "true"
                    ~fim_cena1 = "true"
                        ->DONE
                ***[Olha esse ursinho que o papai comprou para você]
                    Que fofinho, orbigada pai
                    ~ urso = "false"
                    ~ crianca_1Triste = true
                    ~fim_cena1 = "true"
                        ->DONE
        **[Filha, papai lembrava, até comprei esse ursinho]
            Que fofinho, orbigada pai
                ***[Quer saber? Vamos para o parque amanhã!!!]
                    Serio?????
                    Papai você ta falando de verdade mesmo?
                        ****[Estou sim meu amor]
                            EBAAAAAAA!!
                            ORBIGADA PAPAI
                            MAMÃE NÓS VAMOS PARA O PARQUE AMANHÃ
                            ~crianca_1Triste = "false"
                            ~urso = "false"
                                ->DONE
                        ****[Não]
                            Ah... haha me pegou
                            ~crianca_1Triste = "true"
                            ~urso = "false"
                            ~fim_cena1 = "true"
                                ->DONE
                ***[Vai ser divertido, eu prometo]
                    Ta bom...
                    ~crianca_1Triste = "true"
                    ~urso = "false"
                    ~fim_cena1 = "true"
                        ->DONE
    *[Não]
        ~fim_cena1 = "true"
            ->DONE
                    
=== UrsoBom ===
OBRIGADA PAPAII VOCÊ É O MELHOR!!!!!
~urso = "false"
    ->DONE

-> END
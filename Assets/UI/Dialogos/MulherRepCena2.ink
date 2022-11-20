INCLUDE global.ink

#Maria

{Mulher2 == "true": -> muie_3}
{crianca_1 == "false": -> muie_1}
{crianca_1Triste == "true": -> muie_2 | -> muie_feliz }

=== muie_1 ===

Boa noite amor, como foi no trabalho? 
    *[Muito cansativo, como sempre]
        Eu imagino, a cada dia que passa você está mais ocupado
        Só cuidado para não esquecer de nós
        Inclusive, a Carla quer conversar contigo sobre o aniversário dela.
            **[Vou falar com ela]
                Não vai me dizer que tem algo no trabalho amanhã né?!
                    ***[Tem, mas eu não vou]
                        Olha só, essa foi inesperada
                        O homem trabalho pensando em passar um tempo com a sua família?
                        Vai falar isso para ela, que ela vai amar
                            -> DONE
                    ***[Esse é o problema, tem e eu tenho que ir]
                        ...Eu não digo é nada
                        Agora se vira para falar isso para ela
                            -> DONE
            **[Amanhã tem um evento na empresa e eu tenho que ir]
                ...Eu não digo nada
                Agora se vira para falar isso para ela
                    ->DONE

    *[Foi ótimo, a diretoria até me convidou para uma confraternização amanhã.]
        Mas amanhã é o aniversário da nossa filha Pedro
            **[Já é amanha?]
                Pedro...
                Como você não lembra quando é o aniversário da sua filha??
                Fala para ela isso, quero ver
                    ->DONE
            **[Quando foi que eu disse que ia?]
                Olha só, essa foi inesperada
                O homem trabalho pensando em passar um tempo com a sua família?
                Vai falar isso para ela, que ela vai amar
                    -> DONE
 
=== muie_2 ====

Não acredito que você realmente falou isso
Tenta pelo menos comprar algo interessante para ela
Pode ser aquele ursinho que você tinha comprado um tempo atrás, acho que ele está na cozinha.
    ~Mulher2 = "true"
    ->DONE
    
=== muie_feliz ===
Meu Deus se eu estou sonhando não me acorde
Faz quantos anos que esse milagre não acontece, uns 4 anos?
Vamos para o parque então!!
    ~FinalFeliz = "true"
    ->DONE
    
=== muie_3 ===
Pelo menos isso né
    ->DONE

->END
    
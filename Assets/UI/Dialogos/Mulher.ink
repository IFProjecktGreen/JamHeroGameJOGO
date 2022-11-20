INCLUDE global.ink

#Maria
{filha_urso == "true": -> muie_3}
{crianca_1 == "true": -> muie_2 | -> muie_1}

=== muie_1 ===

Boa noite amor, como foi no trabalho? 
    *[Muito cansativo, como sempre]
        Eu imagino, a cada dia que passa você está mais ocupado
        Só cuidado para não esquecer de nós
        Inclusive, a Carla quer conversar contigo sobre o aniversário dela.
            **[Sobre isso...]
                Ah não, de novo Pedro!?
                Resolve isso com ela
                    -> DONE
            **[Amanhã tem um evento na empresa e eu tenho que ir]
                ...Eu não digo nada
                Agora se vira para falar isso com ela
                    ->DONE

    *[Foi ótimo, a diretoria até me convidou para uma confraternização amanhã.]
        Mas amanhã é o aniversário da nossa filha Pedro
            **[Já é amanha?]
                Pedro...
                Como você não lembra quando é o aniversário da sua filha??
                Fala para ela isso, quero ver
                    ->DONE
            **[Comemora no evento]
                Mas ela quer ir para o parque Pedro, faz anos que ela pede isso
                Boa sorte para falar isso com ela
                    -> DONE
 
=== muie_2 ====

Não acredito que você realmente falou isso
Tenta pelo menos comprar algo interessante para ela
Pode ser aquele ursinho que você tinha comprado um tempo atrás, acho que ele está na cozinha.
    ~Mulher2 = "true"
    ->DONE
    
=== muie_3 ===
Pelo menos isso né
    ->DONE

->END
    



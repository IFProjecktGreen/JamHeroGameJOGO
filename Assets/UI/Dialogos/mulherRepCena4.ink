INCLUDE global.ink

#Maria

{SemFesta == "true": -> mulherFeliz}
{chefe == "false": -> mulher1 | -> mulher2}

=== mulher1 ===
Não acredito que nós realmente estamos aqui
    *[Não fica com essa cara que hoje é o meu dia!]
        Era para ser o da sua filha, mas ta certo
            **[Se for ficar assim era melhor nem ter vindo]
                Ai Pedro, ta certo vai logo falar com a tua chefe, ela deve ta esperando
                    ->DONE
            **[Cuida da Carla, eu ja volto]
                ->DONE
    *[Você saber que eu não podia deixar de vir né]
        Ta certo, ta certo
        Trabalho, promoção e etc
            -> DONE

=== mulher2 ===
    Terminou de farrear?
    *[Tu reclama demais serio, eu fui promovido e tu fica emburrada]
        Vamo embora logo
            **[Mas onde está a Carla?]
                Ela estava brincando agora há pouco...
                Eu só fui no banheiro..
                Corre!! Vamos procurar ela 
                ~janela = "true"
                    ->DONE
            **[Ai que mulher rabugenta]
                OkOk Pedro
                To sem paciência
                Chama logo a Carla
                ...
                Cadê ela?
                ~janela = "true"
                    ->DONE
            
    *[SOU GERENTEEEEEEEEEEEE]
        Meu Deus...
        Vamo embora antes que tu desmaie
            **[Mas onde está a Carla?]
                Ela estava brincando agora há pouco...
                Eu só fui no banheiro..
                Corre!! Vamos procurar ela 
                ~janela = "true"
                    ->DONE
            **[Ai que mulher rabugenta]
                OkOk Pedro
                To sem paciência
                Chama logo a Carla
                ...
                Cadê ela?
                ~janela = "true"
                    ->DONE
            
=== mulherFeliz ===
Já voltou? 
    *[Vamos voltar]
        O que foi amor? Você não ia ser promovido?
            **[Prefiro comemorar o aniversário da minha filha]
    *[Não quero mais o cargo]
        Mas você tava se esforçando tanto, o que aconteceu?
            **[Prefiro comemorar o aniversário da minha filha]
    
-O que??? Amor...
-Estou muito feliz contigo agora
-Vamos buscar ela
    -> DONE


->END
INCLUDE global.ink

#Maria

{chefe == "false": -> mulher1 | -> mulher2}

=== mulher1 ===
Não acredito que nós realmente viemos
    *[Não fica com essa cara que hoje é o meu dia!]
        Era para ser o da sua filha, mas tudo bem
            **[Se for ficar assim era melhor nem ter vindo]
                Ai Pedro, está certo, vai logo falar com a tua chefe, ela deve estar te esperando
                    ->DONE
            **[Cuida da Carla, eu já volto]
                ->DONE
    *[Você sabe que eu não podia deixar de vir né!?]
        Certo, certo
        Trabalho, promoção e etc
            -> DONE

=== mulher2 ===
Terminou de farrear?
    *[Tu reclama demais sério, eu fui promovido e tu fica emburrada]
        Vamos embora logo
        ~FimCena4 = "true"
            ->DONE
            
            
    *[SOU GERENTEEEEEEEEEEEE]
        Meu Deus...
        Vamos voltar antes que tu desmaie
        ~FimCena4 = "true"
            ->DONE

->END

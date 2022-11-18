INCLUDE global.ink

#Maria

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
        ~FimCena4 = "true"
            ->DONE
            
    *[SOU GERENTEEEEEEEEEEEE]
        Meu Deus...
        Vamo embora antes que tu desmaie
        ~FimCena4 = "true"
            ->DONE

->END

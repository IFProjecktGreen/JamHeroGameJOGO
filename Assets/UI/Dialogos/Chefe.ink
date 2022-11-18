INCLUDE global.ink

#Chefe

{chefe == "true": -> Chefe2 | -> Chefe}

=== Chefe ===
Olha só quem chegou
O novo gerente da empresa!!!
    *[Boa noite, como estão as coisas por aqui?]
        Estão para ficar melhor
        Como você sabe, a nossa empresa está crescendo muito nos ultimos meses
        Mas nós não estamos aqui para falar sobre isso, mas sim para BEBEEER!!
        ~chefe = "true"
            ->DONE
    *[Cheguei para começar a festa!!!!]
        Esse é o espírito!!
        Vamos comemorar muito esse dia e ano especial para todos nós
        Podem abrir suas cervejas e começar a rodada!!
        ~chefe = "true"
            ->DONE

=== Chefe2 ===
Ai meu Deus, está tudo girando
Acho melhor a gente parar
    ->DONE


-> END
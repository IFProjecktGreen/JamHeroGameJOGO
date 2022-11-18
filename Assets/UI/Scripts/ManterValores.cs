using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManterValores : MonoBehaviour
{
    public string DialogoMenina;
    public string Mulher2;
    public string Urso;
    public string UrsoMenina;
    public string Fim_Cena1;
    public string Chefe;
    public string Fim_Cena4;
    public string CamaCena6;
    public string DemonioContrato;
    public string FinalFeliz;
    public string SemFesta;

    void Update()
    {
         DialogoMenina = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("crianca_1")).value;
         Mulher2 = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("Mulher2")).value;
         Urso = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("urso")).value;
         UrsoMenina = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("filha_urso")).value;
         Fim_Cena1 = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("fim_cena1")).value;
         Chefe = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("chefe")).value;
         Fim_Cena4 = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("FimCena4")).value;
         CamaCena6 = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("CamaCena6")).value;
         DemonioContrato = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("DemonioContrato")).value;
         FinalFeliz = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("FinalFeliz")).value;
         SemFesta = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("SemFesta")).value;
    }

}

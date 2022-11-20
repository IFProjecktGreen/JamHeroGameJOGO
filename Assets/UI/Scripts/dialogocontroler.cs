using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class dialogocontroler : MonoBehaviour
{
    private static dialogocontroler instance;

    //O painel dos diálogos
    [SerializeField] private GameObject dialoguepanel;

    //O texto responsável pelos diálogos 
    [SerializeField] private TextMeshProUGUI TextMeshProUGUI;

    //As opções de escolha para o player
    [SerializeField] private GameObject[] choices;

    //O testo responsável para mostrar o nome do personagem no painel
    [SerializeField] private TextMeshProUGUI nome;

    //Para setar os sprites no painel de dialogo
    [SerializeField] private Image imagem;
    [SerializeField] private Sprite[] spritesList;

    [SerializeField] private bool booleano;

    //Da opções de escolha para o player junto do choices
    private TextMeshProUGUI[] choicestext;

    //História
    private Story currentStory;

    public bool dialogoIsOn;
    private bool continuar;
    private bool verificacaoEscolha;

    private Coroutine DisplayLineCoroutine;

    [SerializeField] private float VelocidadeLetra = 1f;

    //A tag para definir o nome do personagem
    const string falante_tag = "falante";

    private dialogovariaveis dialogovariaveis;

    [Header("Load Globals JSON")]
    [SerializeField] private TextAsset loadGlobalsJSON;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.Log("Found more than one Dialogue Manager in the scene");
        }

        instance = this;
        dialogovariaveis = new dialogovariaveis(loadGlobalsJSON);
    }

    public static dialogocontroler GetInstance()
    {
        return instance;
    }

    private void Start()
    {
        dialogoIsOn = false;
        continuar = false;
        verificacaoEscolha = true;

        dialoguepanel.SetActive(false);

        choicestext = new TextMeshProUGUI[choices.Length];
        int index = 0;

        foreach (GameObject choice in choices)
        {
            choicestext[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }
    }

    private void Update()
    {
        if (!dialogoIsOn)
        {
            return;
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            continueStory();
        }

    }

    public void InDialogueMode(TextAsset inkJSON)
    {
        //Vai setar a história para as variáveis e inicar o diálogo
        currentStory = new Story(inkJSON.text);
        dialogoIsOn = true;
        dialoguepanel.SetActive(true);
        nome.text = "";

        dialogovariaveis.StartListening(currentStory);
    }

    void ExitDialogueMode()
    {
        dialogovariaveis.StopListening(currentStory);

        //Aqui nós temos o termino do script.
        dialogoIsOn = false;
        dialoguepanel.SetActive(false);
        TextMeshProUGUI.text = "";
    }

    void continueStory()
    {
        //Com a letra determinada no Update pressionada essa função vai atualizar a tela para o player
        if (verificacaoEscolha)
        {
            if (currentStory.canContinue)
            {
                //Caso tenha história para contiuar entra aq
                if (DisplayLineCoroutine != null)
                {
                    StopCoroutine(DisplayLineCoroutine);
                }
                DisplayLineCoroutine = StartCoroutine(Displayline(currentStory.Continue()));
                DisplayChoices();
                HandleTags(currentStory.currentTags);
            }
            else
            {
                //Caso não tenha mais história entra aq
                ExitDialogueMode();
            }
        }
    }

    private IEnumerator Displayline(string line)
    {
        //Aqui traz o efeito de digitaçao na caixa de diálogo
        TextMeshProUGUI.text = "";

        foreach (char letra in line.ToCharArray())
        {
            TextMeshProUGUI.text += letra;
            yield return new WaitForSeconds(VelocidadeLetra);
        }
    }

    void HandleTags(List<string> currentTags)
    {
        foreach (string tag in currentTags)
        {
            string tagValue = tag.Trim();
            nome.text = tagValue;
        }
        SetImage();
    }

    void SetImage()
    {
        if (nome.text == "Maria")
        {
            imagem.sprite = spritesList[0];
        }
        else if (nome.text == "Carla")
        {
            imagem.sprite = spritesList[1];
        }
        else if ( nome.text == "Urso")
        {
            imagem.sprite = spritesList[2];
        }
        else if (nome.text == "Chefe")
        {
            imagem.sprite = spritesList[3];
        }
        else if( nome.text == "???")
        {
            imagem.sprite = spritesList[4];
        }
        else if( nome.text == "Cama")
        {
            imagem.sprite = spritesList[5];
        }
        else if(nome.text == "Janela")
        {
            imagem.sprite = spritesList[6];
        }
        else if(nome.text == "carla")
        {
            imagem.sprite = spritesList[7];
        }
    }


    void DisplayChoices()
    {
        //Aqui nós temos o painel das escolhas que serão chamados pelo ContinueStory para atualizar as escolhas
        //e definir as novas
        List<Choice> currentChoices = currentStory.currentChoices;

        if (currentChoices.Count > choices.Length)
        {
            Debug.LogError("mais escolhas que o UI suporta. Os números de escolha são: " + currentChoices.Count);
        }

        int index = 0;

        foreach (Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicestext[index].text = choice.text;
            index++;
            verificacaoEscolha = false;
        }

        for (int i = index; i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false);
        }
    }

    public void MakeChoices(int ChoiceIndex)
    {
        //Aqui é a função que é chamada pelo Button quando ele é pressionado
        currentStory.ChooseChoiceIndex(ChoiceIndex);
        verificacaoEscolha = true;
        continueStory();
    }

    public Ink.Runtime.Object GetVariableState(string VariablesNames)
    {
        Ink.Runtime.Object variableValue = null;
        dialogovariaveis.variables.TryGetValue(VariablesNames, out variableValue);
        if(variableValue == null)
        {
            Debug.Log("Deu erro em pegar as variaveis");
        }
        return variableValue;
    }
}

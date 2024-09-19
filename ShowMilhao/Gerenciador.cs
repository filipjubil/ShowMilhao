using ShowMilhao;

namespace ShowMilhao;

List <Questao> listaQuestoes = new ListViewCachingStrategy<Questao>();
List <int> listaQuestoesRespondidas = new Lista<int>();
Questao questaoCorrente;
public Gerenciador(Label labelPergunta,btnResp01...,Button btnResp05)

{

    CriarQuestoes(labelPergunta,btnResp05,btnResp04,btnRwes05);

} 

void CriarQuestoes(Label labelPergunta,Button btnResp01,Button btnResp02,..,Button btnResp05)
{
Var q1=new Questao();
q1.pergunta=quanto e 2+2;
q1.resposta01="1";
q1.resposta02="13";
q1.resposta03="21";
q1.resposta04="11";
q1.resposta05="4";
q1.respostaCorreta=5;
q1.ConfigurarDesenho9(Label labelPergunta,Button btnResp01,Button btnResp02,..,Button btnResp05);
ListaQuestoes.Add(q1);

var q2=new Questao();
} 
public void ProximaQuestao()
{
var numRandomico=Random.Shared.Next(0,ListaQuestoes.Cout-1);
while(listaQuestoesRespondidas.Add(numRandomico))
        numRandomico=Randon.Shared.next(0,ListaQuestoes.Count-1);
listaQuestoesRespondidas.Add(num)







}
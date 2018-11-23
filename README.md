# testeEntrevista

<h3>Introdução</h3>
<p>Este teste visa validar seus conhecimentos. A ideia é que você tenha a autonomia para
entender a necessidade, verificar a documentação disponível e, por fim, desenvolver o que
foi proposta da melhor maneira possível. Embora simples, o teste permite que você utilize
seus conhecimentos para deixá-lo com uma arquitetura mais profissional.</p>
<p>Os quesitos avaliados são os seguintes:</p>
<ul>
<li>- Utilização de conceitos de design patters (N camadas, Injeção de dependência, etc);</li>
<li>- Conhecimentos de padrão de ASP NET API</li>
<li>- Conhecimentos de REST/JSON</li>
<li>- Conhecimentos básicos de Javascript, jQuery e bibliotecas JS</li>
<li>- Conhecimentos e utilização de bibliotecas frontend (Bootstrap, Fontawesome, etc);</li>
</ul>
<h3>Questão 1</h3>
<p>Magento é o sistema de e-commerce Open Source mais famoso e utilizado no mundo. Ele
possui uma interface de integração via SOAP (utilizando XML) que permite busca de
pedidos, clientes, produtos, etc.</p>
<p>Esta questão propõe que você desenvolva uma integração que busque um produto no
webservice e retorne suas propriedades em formato JSON.</p>
<p>Dados do webservice:</p>
<ul>
<li>- Endpoint: </li>
<li>- Usuário: </li>
<li>- senha:</li>
</ul>
<h3>Detalhamento</h3>
<ol>
<li> Crie um projeto do tipo web em branco. Adicione um Controller.</li>
<li> Esse controller deve conter uma action que receberá um parâmetro chamado: Id do
produto.</li>
<li> Ao ser chamado, essa action deve pesquisar no webservice acima pelo ID do Produto
informado.</li>
<li> O resultado da chamada deverá retornar um objeto JSON com os seguintes campos:</li>
<ul>
<li>Nome do produto</li>
<li>Id do produto</li>
<li>Valor do produto</li>
</ul>
</ol>

<h3>Importante</h3>
<ul>
<li>A documentação da API:
http://devdocs.magento.com/guides/m1x/api/soap/introduction.html</li>
<li>Antes de mais nada, chame o método “login” do webservice utilizando as credenciais
acima. O retorno deve ser passado nas demais chamadas do serviço.</li>
<li>Você não precisa utilizar arquiteturas complexas, mas lembre-se de conceitos básicos de
reuso de código, facilidade de manutenção e tipagem.</li>
</ul>

<h3>Questão 2</h3>
<p>Agora você deve criar a interface do usuário para a questão anterior. Crie uma página
simples que irá chamar o método anterior, via AJAX, e exibir o resultado para o usuário.</p>
<ol>
<li>Crie um novo controller e sua respectiva view.</li>
<li>A view deve conter um simples campo - ID do Produto. O usuário deve preenchê-lo e
clicar no botão de busca.</li>
<li>Via ajax, o sistema deve chamar o serviço criado na Questão 1 e exibir o resultado
(devidamente formatado) ao usuário;</li>
</ol>
<h3>Importante</h3>
<ul>
<li>A questão irá avaliar conceitos de Javascript, CSS e HTML. Tente ser o mais consistente
possível nessa página;</li>
<li>Para auxiliar no CSS, você pode utilizar o Bootstrap;</li>
<li>A beleza da página em sí não é avaliada, mas o entendimento e a aplicação correta dos
conceitos sim.</li>
</ul>


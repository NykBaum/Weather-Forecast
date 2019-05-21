# Weather-Forecast
Projeto de previsão climática

- Nesse projeto foi utilizado o padrão MVC.
- Foi utilizado JQuery como um framework de frontend.
- Foi feito um backup do banco de dados para facilitar a importação. Esse arquivo está disponível neste repositório 
com o nome BancoDeDados.bak.

Para conseguir compilar/utilizar o sistema é necessário fazer a importação do banco de dados e posteriormente configurar a 
string de conexão no arquivo Web.config existente no projeto do Visual Studio.

Para desenvolvimento do projeto foi utilizado Visual Studio Community 2019.


Funcionamento do sistema:

- Tela inicial(index) apresenta a lista de cidades cadastradas com a opção de consultar a previsão detalhada dos prósximos 5 dias,
e também possui um link de acesso para a tela de cadastro de cidade.

- Tela de cadastro, possui um campo para o cadastro da cidade, somente nome. 
  - Caso a cidade informada não tenha dados retornado pela API o sistema apresentará uma mensagem informando que não existem dados de 
  previsão para esta cidade. 
  - Caso a cidade já tenha sido cadastrada em outro momento, o sistema apresentará uma mensagem informando que a cidade já está cadastrada
  e não duplicará o cadastro.
  - Ao cadastrar uma nova cidade um código de registro será gerado automaticamente para ela.
  
- Tela de Previsão, apresenta uma previsão do tempo detalhada dos próximos 5 dias seguintes ao atua subdivididos de 3 em 3 horas. Nesta 
previsão são exibidas as temperaturas máxima e mínima, a umidade e uma descrição resumida do tempo no período.

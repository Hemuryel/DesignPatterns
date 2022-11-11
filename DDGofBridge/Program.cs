namespace DDGofBridge
{
    internal class Program
    {
        /* Bridge
         * 
         * separar a responsabilidade da hierarquia de classes
         * 
         * utilizado quando é desejável que uma interface possa variar independentemente das suas implementações
         */

        static void Main(string[] args)
        {
            IMensagem mensagem = new MensagemCliente("Fulano");
            IEnviador enviador = new EnviarSMS();
            mensagem.Enviador = enviador;
            mensagem.Enviar();
        }
    }
}
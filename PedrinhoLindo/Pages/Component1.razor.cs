using Microsoft.AspNetCore.Components;

namespace PedrinhoLindo.Pages
{
    public partial class Component1
    {
        public string Nome { get; set; }

        public string Teste
        {
            get => _teste;
            set
            {
                _teste = value;

                InvokeAsync(() => StateHasChanged());
            }
        }
        private string _teste;
    }
}

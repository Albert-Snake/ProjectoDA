using System.Collections.Generic;
namespace Model
{
    public interface IAcessoDB<T>
    {
        bool SalvarUsuario(T registro);
        List<T> GetUsuarios();
        T GetUsuarioPorLoginSenha(T registro);
        T GetUsuarioPorCodigo(int codigo);
    }
}
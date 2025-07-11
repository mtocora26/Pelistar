using System;
namespace Pelistar_beta.Clases
{
public class Usuario
{
	public int idUsario { get; set; }    
	public string nombreUsuario { get; set; }
	public string emailUsario { get; set; }
	public string rolUsario { get; set; }
	public string passwordUsuario { get; set; }
	public Usuario()
	{
	}
	public Usuario(int idUsario, string nombreUsuario, string emailUsario, string rolUsario, string passwordUsuario)
	{
		this.idUsario = idUsario;
		this.nombreUsuario = nombreUsuario;
		this.emailUsario = emailUsario;
		this.rolUsario = rolUsario;
		this.passwordUsuario = passwordUsuario;
	}
}
}
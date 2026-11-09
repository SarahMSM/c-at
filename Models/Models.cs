using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chat
{
    [Table("usuarios")]
    public class Usuario
    {
        [Key, Column("id")] public int Id { get; set; }
        [Column("codigo")] public string Codigo { get; set; }
        [Column("pin")] public string Pin { get; set; }
    }

    [Table("contatos")]
    public class Contato
    {
        [Key, Column("id")] public int Id { get; set; }
        [Column("contato_id")] public int ContatoId { get; set; }
        [Column("nome")] public string Nome { get; set; }
        [Column("usuario_id")] public int UsuarioId { get; set; }

        [ForeignKey(nameof(ContatoId))] public Usuario ContatoUsuario { get; set; }
    }

    [Table("conversas")]
    public class Conversa
    {
        [Key, Column("id")] public int Id { get; set; }
        [Column("titulo")] public string Titulo { get; set; }
        [Column("criado_por")] public int CriadoPor { get; set; }
        [Column("criado_em", TypeName = "timestamp")] public DateTime CriadoEm { get; set; }
    }

    [Table("usuario_conversas")]
    public class UsuarioConversa
    {
        [Key, Column("id")] public int Id { get; set; }
        [Column("usuario_id")] public int UsuarioId { get; set; }
        [Column("conversa_id")] public int ConversaId { get; set; }
        [Column("saiu_em", TypeName = "timestamp")] public DateTime? SaiuEm { get; set; }

        [ForeignKey(nameof(UsuarioId))] public Usuario Usuario { get; set; }
        [ForeignKey(nameof(ConversaId))] public Conversa Conversa { get; set; }
    }

    [Table("mensagens")]
    public class Mensagem
    {
        [Key, Column("id")] public int Id { get; set; }
        [Column("usu_conv_id")] public int UsuConvId { get; set; }
        [Column("texto")] public string Texto { get; set; }
        [Column("data_hora", TypeName = "timestamp")] public DateTime DataHora { get; set; }

        [ForeignKey(nameof(UsuConvId))] public UsuarioConversa UsuarioConversa { get; set; }
    }

    // ---- Itens usados pelas Views (DTOs) ----
    public class ItemContato
    {
        public int Id { get; set; }
        public int ContatoId { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
    }

    public class ItemConversa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool Saiu { get; set; }
        public DateTime Ultima { get; set; }
    }

    public class ItemMensagem
    {
        public int Id { get; set; }
        public string Autor { get; set; }
        public DateTime DataHora { get; set; }
        public string Texto { get; set; }
        public bool Minha { get; set; }
    }
}

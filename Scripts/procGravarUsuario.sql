create procedure procGravarUsuario
	@pStrNome varchar(60),
	@pStrSobrenome varchar(60),
	@pDtDataNacimento datetime,
	@pStrDocumento varchar(15),
	@pstrNacionalidade varchar(15),
	@pStrUsuario varchar(60),
	@pStrSenha varchar(40),
	@pIntResult int output
as
begin
	declare @pintIdPessoa int
	declare @pintIdade int
	declare @pIntCodNacionalidade int


	set @pintIdade =  cast (DATEDIFF(DD, @pDtDataNacimento, GETDATE())/365.25 as int)

	set @pIntCodNacionalidade = (select intCodPais from Paises Where strNomePais = @pstrNacionalidade)

	if (select intIdadeMin from IdadeMinPorNacionalidade where intCodNacionalidade = @pIntCodNacionalidade) <= @pintIdade 
		begin
			insert into Pessoa
			(
				strNome,
				strSobrenome,
				dtDataNacimento,
				strDocumento,
				intCodNacionalidade
			)
			values
			(
				@pStrNome,
				@pStrSobrenome,
				@pDtDataNacimento,
				@pStrDocumento,
				@pIntCodNacionalidade
			)

			set @pintIdPessoa = scope_identity()

			insert into Usuario
			(
				intCodPessoa,
				strUsuario,
				strSenha
			)
			values
			(
				@pintIdPessoa,
				@pStrUsuario,
				@pStrSenha
			)
			return SCOPE_IDENTITY()
		end
	else
		begin
			return 0
		end

	

	
end
go
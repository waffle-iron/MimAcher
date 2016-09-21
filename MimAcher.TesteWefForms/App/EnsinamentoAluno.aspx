﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnsinamentoAluno.aspx.cs" MasterPageFile="~/Site.Master" Inherits="MimAcher.TesteWefForms.App.EnsinamentoAluno" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="main">
   
<%-- Window --%>
    <ext:Window ID="EnsinoAlunoWindowId" Width="400" Height="290" Modal="true" runat="server" Hidden="true">
        <Items>

        <%-- Form --%>
        <ext:FormPanel ID="EnsinoAlunoFormPanelId" runat="server" Title="Aluno" BodyPadding="5" ButtonAlign="Right" Layout="Column">    
                               
            <FieldDefaults LabelAlign="Left" MsgTarget="Side" Size="100" AllowBlank="false" />
                                                        
            <Items> 
            
                <ext:FieldSet ID="EnsinoAlunoFieldSetId" runat="server" Title="Aluno" MarginSpec="0 0 0 10">                                                      
                    <Defaults>
                        <ext:Parameter Name="AllowBlank" Value="true" Mode="Raw" />
                        <ext:Parameter Name="MsgTarget" Value="side" />                                
                    </Defaults>
                    <Items>

                        <%-- Código do Ensinamento do Aluno --%>
                        <ext:TextField ID="cod_aeId" Name="cod_ae"  runat="server" FieldLabel="Código" />

                        <%-- Combobox do Aluno --%>
                        <ext:ComboBox ID="cod_alId" Width="300" Name="cod_al" AllowBlank="false" runat="server" FieldLabel="Nome do Aluno" ValueField="cod_al_combo" DisplayField="nomea_combo">
                            <Store>
                                <ext:Store ID="StoreAlunoId" runat="server">
                                    <Model>
                                        <ext:Model ID="ModelAlunoId" runat="server">
                                            <Fields>
                                                <ext:ModelField Name="cod_al_combo" Mapping="cod_al" />
                                                <ext:ModelField Name="nomea_combo" Mapping="nome" />
                                            </Fields>
                                        </ext:Model>
                                    </Model>
                                </ext:Store>
                            </Store>
                        </ext:ComboBox>   

                        <%-- Combobox do Ensinamento --%>
                        <ext:ComboBox ID="cod_eId" Width="300" Name="cod_e" AllowBlank="false" runat="server" FieldLabel="Aprende" ValueField="cod_e_combo" DisplayField="nome_combo">
                            <Store>
                                <ext:Store ID="StoreEnsinoId" runat="server">
                                    <Model>
                                        <ext:Model ID="ModelEnsinoId" runat="server">
                                            <Fields>
                                                <ext:ModelField Name="cod_e_combo" Mapping="cod_e" />
                                                <ext:ModelField Name="nome_combo" Mapping="nome" />
                                            </Fields>
                                        </ext:Model>
                                    </Model>
                                </ext:Store>
                            </Store>
                        </ext:ComboBox>   
                        
                    </Items>
                </ext:FieldSet>
            </Items>

            <BottomBar>
                <ext:StatusBar ID="AlunoBarId" runat="server" />
            </BottomBar>

            <%-- Botões do Form --%>
            <Buttons>
                <ext:Button ID="SaveButtonId" runat="server" Text="Save" Disabled="false" FormBind="true" OnDirectClick="Save" />
                <ext:Button ID="CancelButtonId" runat="server" Text="Cancel" OnClientClick="#{AlunoWindowId}.hide()"/>
            </Buttons>

            </ext:FormPanel>
        </Items>   
    </ext:Window>

    <%-- Store da Grid --%>
    <Store>
        <ext:Store ID="StoreEnsinoAlunoId" runat="server" PageSize="31" OnReadData="List" RemoteSort="true" AutoLoad="true">
            <Model>
                <ext:Model ID="ModelEnsinoAlunoId" runat="server" IDProperty="cod_ae">
                    <Fields>
                        <ext:ModelField Name="cod_ae" Type="Int" />
                        <ext:ModelField Name="cod_al" Type="Int" />
                        <ext:ModelField Name="cod_e" Type="Int" />
                        <ext:ModelField Name="nomea"  Mapping="nome" Type="String" ServerMapping="MA_ALUNO.nome"  />
                        <ext:ModelField Name="nome" Type="String" ServerMapping="MA_ENSINAR.nome"  />                        
                    </Fields>
                </ext:Model>
            </Model>
        </ext:Store>
    </Store>

 <%-- Grid --%> 
 <ext:GridPanel 
        ID="EnsinoAlunoGridPanelId"
        runat="server" 
        Title="Gerenciamento de Aluno"
        StoreID="StoreEnsinoAlunoId">         
        
        <%-- Colunas da Grid --%>
        <ColumnModel>
            <Columns>
                <ext:Column ID="cod_aeColumnId" runat="server" Text="Código" DataIndex="cod_ae" Visible="false" />
                <ext:Column ID="nomeaColumnId" runat="server" Text="Nome Aluno" Flex="2" DataIndex="nomea" />                                  
                <ext:Column ID="nomeColumnId" runat="server" Text="Aprende" Flex="2" DataIndex="nome" />                                                  
            </Columns>            
        </ColumnModel>    
           
        <SelectionModel>
            <ext:RowSelectionModel ID="EnsinoAlunoRowSelectionModelId" Mode="Single" runat="server" >
                    <Listeners>                        
                        <Select Handler="#{EnsinoAlunoFormPanelId}.getForm().loadRecord(record); 
                                         #{EditButtonId}.setDisabled(false);
                                         #{DeleteButtonId}.setDisabled(false);" />                      
                    </Listeners>                    
            </ext:RowSelectionModel>                        
        </SelectionModel>  

        <%-- Botões da Grid --%>
        <TopBar>
            <ext:Toolbar ID="ToolbarId" runat="server">
                <Items>
                    <%-- Incluir --%>
                    <ext:Button ID="IncluirButtonId" runat="server" Text="Novo Registro" Icon="PageAdd" OnClientClick="#{AlunoWindowId}.show();#{AlunoFormPanelId}.getForm().reset();" />

                    <%-- Edit --%>
                    <ext:Button ID="EditButtonId" runat="server" Text="Editar" Icon="PageEdit" Disabled="true" >
                        <DirectEvents>
                            <Click OnEvent="Edit">
                                <ExtraParams>
                                    <ext:Parameter Name="RecordGrid" Mode="Raw" Value="#{EnsinoAlunoGridPanelId}.getRowsValues({selectedOnly : true})[0].cod_ae" />                                
                                </ExtraParams>
                            </Click>
                        </DirectEvents>
                    </ext:Button>

                    <%-- Delete --%>
                    <ext:Button ID="DeleteButtonId" runat="server" Text="Excluir Registro" Icon="Delete" Disabled="true" >
                        <DirectEvents>
                            <Click OnEvent="Delete">
                                <Confirmation ConfirmRequest="true" Message="Deseja excluir este registro?" />                                
                            </Click>
                        </DirectEvents>
                    </ext:Button>

                    <%-- Atualizar --%>
                    <ext:Button ID="AtualizarButtonId" runat="server" Text="Atualizar" Icon="Reload" OnDirectClick="List" /> 
                </Items>
            </ext:Toolbar>
        </TopBar>

        <%-- Double Click --%>
        <DirectEvents>
            <ItemDblClick OnEvent="Edit">
                <ExtraParams>                    
                    <ext:Parameter Name="RecordGrid" Mode="Raw" Value="#{EnsinoAlunoGridPanelId}.getRowsValues({selectedOnly : true})[0].cod_ae" />                                
                </ExtraParams>
            </ItemDblClick>
        </DirectEvents>

        <BottomBar>
            <ext:PagingToolbar ID="PagingToolbarId" runat="server" />
        </BottomBar>

    </ext:GridPanel>

</asp:Content>

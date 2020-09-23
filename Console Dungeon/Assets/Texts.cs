using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Dungeon
{
    public class Texts
    {
        public string introGame = "Bem-vindo ao Console Dungeon";
        public string askAboutSaveGame = "Savegame encontrado\n" + "Deseja carregar o jogo anterior?";
        public string explainGame = "Esse é um jogo feito para testar sua imaginação e memorização!\n\n\n" +
                                    "Seu personagem está sendo perseguido por um monstro em nossa dungeon\n" +
                                    "e o seu objetivo é vasculhar as salas para encontrar uma espada\n" +
                                    "assim, vencendo o monstro e conseguindo sair da dungeon!\n\n\n" +
                                    "Vamos começar com as opções de gameplay:\n" +
                                    "Você deverá navegar entre as salas da dungeon.\n" +
                                    "o game será divido em rodadas, a cada rodada você deverá escolher uma direção\n" +
                                    "Norte (cima)\n" +
                                    "Sul (baixo)\n" +
                                    "Leste (direta)\n" +
                                    "Oeste (esquerda)\n\n" +
                                    "A cada duas rodadas o monstro, que te persegue, se moverá pela dungeon,\n" +
                                    "Caso você não tenha o item 'sword' e encontre o monstro, seu hp diminuirá em 1hp e sua opção será fugir na próxima rodada\n\n\n" +
                                    "Vamos começar e boa sorte\n" +
                                    "cuidado, nem tudo é tão simples...\n\n";

        public string options = "O quê você deseja fazer?\n" +
                                "Norte (cima)\n" +
                                "Sul (baixo)\n" +
                                "Leste (direta)\n" +
                                "Oeste (esquerda)\n\n" +
                                "Salvar (barra de espaço)\n" +
                                "Sair (esc)\n";
        public string savedGame = "Jogo salvo com sucesso";
        public string saveRestored = "Jogo restaurado com sucesso";
        public string loserMessage = "";
        public string congratulationsMessage = "";
        public string invalidaCommand = "";
        public string passBlocked = "";
        public string yesOrNot = "(y) para sim ou (n) para não";
    }
}

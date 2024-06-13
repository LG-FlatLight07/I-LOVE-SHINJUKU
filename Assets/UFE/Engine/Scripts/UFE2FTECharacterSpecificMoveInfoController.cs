using System;
using System.Collections.Generic;
using UnityEngine;
using UFE3D;

namespace FreedTerror
{
    public class UFE2FTECharacterSpecificMoveInfoController : MonoBehaviour
    {
        [Serializable]
        private class DefaultMoveInfoOptions
        {
            public string introMoveName;
            public string roundWinOutroMoveName;
            public string timeOutOutroMoveName;
            public string gameWinOutroMoveName;
        }

        [Serializable]
        private class OpponentMoveInfoOptions
        {
            public string[] opponentCharacterNames;
            public string introMoveName;
            public string roundWinOutroMoveName;
            public string timeOutOutroMoveName;
            public string gameWinOutroMoveName;
        }

        [Serializable]
        private class CharacterSpecificMoveInfoOptions
        {
            public string characterName;
            [Header("DEFAULT MOVE INFO OPTIONS")]
            public DefaultMoveInfoOptions defaultMoveInfoOptions;
            [Header("OPPONENT MOVE INFO OPTIONS")]
            public OpponentMoveInfoOptions[] opponentMoveInfoOptions;
        }
        [Header("CHARACTER SPECIFIC MOVE INFO OPTIONS")]
        [SerializeField]
        private CharacterSpecificMoveInfoOptions[] characterSpecificMoveInfoOptions;

        private List<StanceInfo> loadedStanceInfos = new List<StanceInfo>();

        // Update is called once per frame
        void Update()
        {
            UpdateCharacterSpecificMoveInfoOptions();
        }

        void OnDisable()
        {
            loadedStanceInfos.Clear();
        }

        void OnDestroy()
        {
            loadedStanceInfos.Clear();
        }

        private void UpdateCharacterSpecificMoveInfoOptions()
        {
            if (UFE.config.player1Character != null
                && UFE.config.player2Character == null)
            {
                UpdateDefaultMoveInfoOptions(UFE.config.player1Character);
            }
            else if (UFE.config.player1Character == null
                && UFE.config.player2Character != null)
            {
                UpdateDefaultMoveInfoOptions(UFE.config.player2Character);
            }
            else if (UFE.config.player1Character != null
                && UFE.config.player2Character != null)
            {
                UpdateDefaultMoveInfoOptions(UFE.config.player1Character);

                UpdateDefaultMoveInfoOptions(UFE.config.player2Character);

                UpdateOpponentMoveInfoOptions(UFE.config.player1Character, UFE.config.player2Character);

                UpdateOpponentMoveInfoOptions(UFE.config.player2Character, UFE.config.player1Character);
            }
        }

        private void UpdateDefaultMoveInfoOptions(UFE3D.CharacterInfo characterInfo)
        {
            int length = characterInfo.moves.Length;
            for (int i = 0; i < length; i++)
            {
                int lengthA = characterSpecificMoveInfoOptions.Length;
                for (int a = 0; a < lengthA; a++)
                {
                    if (characterInfo.characterName != characterSpecificMoveInfoOptions[a].characterName) continue;

                    //characterInfo.moves[i].cinematicIntro = GetMoveInfoFromMoveInfos(characterSpecificMoveInfoOptions[a].defaultMoveInfoOptions.introMoveName, characterInfo.moves[i].attackMoves);
                    //
                    //characterInfo.moves[i].roundOutro = GetMoveInfoFromMoveInfos(characterSpecificMoveInfoOptions[a].defaultMoveInfoOptions.roundWinOutroMoveName, characterInfo.moves[i].attackMoves);
                    //
                    //characterInfo.moves[i].timeOutOutro = GetMoveInfoFromMoveInfos(characterSpecificMoveInfoOptions[a].defaultMoveInfoOptions.timeOutOutroMoveName, characterInfo.moves[i].attackMoves);
                    //
                    //characterInfo.moves[i].cinematicOutro = GetMoveInfoFromMoveInfos(characterSpecificMoveInfoOptions[a].defaultMoveInfoOptions.gameWinOutroMoveName, characterInfo.moves[i].attackMoves);

                    break;
                }
            }

            foreach (string path in characterInfo.stanceResourcePath)
            {               
                loadedStanceInfos.Add(Resources.Load<StanceInfo>(path));
            }

            int count = loadedStanceInfos.Count;
            for (int i = 0; i < count; i++)
            {
                int lengthA = characterSpecificMoveInfoOptions.Length;
                for (int a = 0; a < lengthA; a++)
                {
                    //loadedStanceInfos[i].cinematicIntro = GetMoveInfoFromMoveInfos(characterSpecificMoveInfoOptions[a].defaultMoveInfoOptions.introMoveName, loadedStanceInfos[i].attackMoves);
                    //
                    //loadedStanceInfos[i].roundOutro = GetMoveInfoFromMoveInfos(characterSpecificMoveInfoOptions[a].defaultMoveInfoOptions.roundWinOutroMoveName, loadedStanceInfos[i].attackMoves);
                    //
                    //loadedStanceInfos[i].timeOutOutro = GetMoveInfoFromMoveInfos(characterSpecificMoveInfoOptions[a].defaultMoveInfoOptions.timeOutOutroMoveName, loadedStanceInfos[i].attackMoves);
                    //
                    //loadedStanceInfos[i].cinematicOutro = GetMoveInfoFromMoveInfos(characterSpecificMoveInfoOptions[a].defaultMoveInfoOptions.gameWinOutroMoveName, loadedStanceInfos[i].attackMoves);
                }
            }

            loadedStanceInfos.Clear();
        }

        private void UpdateOpponentMoveInfoOptions(UFE3D.CharacterInfo characterInfo, UFE3D.CharacterInfo opponentCharacterInfo)
        {
            int length = characterInfo.moves.Length;
            for (int i = 0; i < length; i++)
            {
                int lengthA = characterSpecificMoveInfoOptions.Length;
                for (int a = 0; a < lengthA; a++)
                {
                    if (characterInfo.characterName != characterSpecificMoveInfoOptions[a].characterName) continue;

                    int lengthB = characterSpecificMoveInfoOptions[a].opponentMoveInfoOptions.Length;
                    for (int b = 0; b < lengthB; b++)
                    {
                        int lengthC = characterSpecificMoveInfoOptions[a].opponentMoveInfoOptions[b].opponentCharacterNames.Length;
                        for (int c = 0; c < lengthC; c++)
                        {
                            if (opponentCharacterInfo.characterName != characterSpecificMoveInfoOptions[a].opponentMoveInfoOptions[b].opponentCharacterNames[c]) continue;

                            //characterInfo.moves[i].cinematicIntro = GetMoveInfoFromMoveInfos(characterSpecificMoveInfoOptions[a].opponentMoveInfoOptions[b].introMoveName, characterInfo.moves[i].attackMoves);
                            //
                            //characterInfo.moves[i].roundOutro = GetMoveInfoFromMoveInfos(characterSpecificMoveInfoOptions[a].opponentMoveInfoOptions[b].roundWinOutroMoveName, characterInfo.moves[i].attackMoves);
                            //
                            //characterInfo.moves[i].timeOutOutro = GetMoveInfoFromMoveInfos(characterSpecificMoveInfoOptions[a].opponentMoveInfoOptions[b].timeOutOutroMoveName, characterInfo.moves[i].attackMoves);
                            //
                            //characterInfo.moves[i].cinematicOutro = GetMoveInfoFromMoveInfos(characterSpecificMoveInfoOptions[a].opponentMoveInfoOptions[b].gameWinOutroMoveName, characterInfo.moves[i].attackMoves);

                            break;
                        }
                    }

                    break;
                }
            }

            foreach (string path in characterInfo.stanceResourcePath)
            {
                loadedStanceInfos.Add(Resources.Load<StanceInfo>(path));
            }

            int count = loadedStanceInfos.Count;
            for (int i = 0; i < count; i++)
            {
                int lengthA = characterSpecificMoveInfoOptions.Length;
                for (int a = 0; a < lengthA; a++)
                {
                    if (characterInfo.characterName != characterSpecificMoveInfoOptions[a].characterName) continue;

                    int lengthB = characterSpecificMoveInfoOptions[a].opponentMoveInfoOptions.Length;
                    for (int b = 0; b < lengthB; b++)
                    {
                        int lengthC = characterSpecificMoveInfoOptions[a].opponentMoveInfoOptions[b].opponentCharacterNames.Length;
                        for (int c = 0; c < lengthC; c++)
                        {
                            if (opponentCharacterInfo.characterName != characterSpecificMoveInfoOptions[a].opponentMoveInfoOptions[b].opponentCharacterNames[c]) continue;

                            //loadedStanceInfos[i].cinematicIntro = GetMoveInfoFromMoveInfos(characterSpecificMoveInfoOptions[a].opponentMoveInfoOptions[b].introMoveName, loadedStanceInfos[i].attackMoves);
                            //
                            //loadedStanceInfos[i].roundOutro = GetMoveInfoFromMoveInfos(characterSpecificMoveInfoOptions[a].opponentMoveInfoOptions[b].roundWinOutroMoveName, loadedStanceInfos[i].attackMoves);
                            //
                            //loadedStanceInfos[i].timeOutOutro = GetMoveInfoFromMoveInfos(characterSpecificMoveInfoOptions[a].opponentMoveInfoOptions[b].timeOutOutroMoveName, loadedStanceInfos[i].attackMoves);
                            //
                            //loadedStanceInfos[i].cinematicOutro = GetMoveInfoFromMoveInfos(characterSpecificMoveInfoOptions[a].opponentMoveInfoOptions[b].gameWinOutroMoveName, loadedStanceInfos[i].attackMoves);

                            break;
                        }
                    }

                    break;
                }
            }

            loadedStanceInfos.Clear();
        }

        private MoveInfo GetMoveInfoFromMoveInfos(string moveName, MoveInfo[] moveInfos)
        {
            int length = moveInfos.Length;
            for (int i = 0; i < length; i++)
            {
                if (moveName != moveInfos[i].moveName) continue;

                return moveInfos[i];
            }

            return null;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayTest
    {
        [UnityTest]
        public IEnumerable pawnSpawn()
        {
            var gameObject = new GameObject();

            Game game = gameObject.AddComponent<Game>();

            game.Start();

            GameObject pawn = game.Create("white_pawn", 0, 6);
            Chessman pawned = pawn.GetComponent<Chessman>();
            Assert.AreEqual("white_pawn", pawned.name);

            yield return null;

        }

        [UnityTest]
        public IEnumerable pawn960Bishop()
        {
            var gameObject = new GameObject();

            Game game = gameObject.AddComponent<Game>();

            game.Start();

            int position = Random.Range(1, 5);
            position = (position * 2) - 1;

            GameObject bishop = game.GetPosition(position, 0);
            Chessman bishoped = bishop.GetComponent<Chessman>();
            Assert.AreEqual("white_bishop", bishoped);

          
            yield return null;
        }

        [UnityTest]
        public IEnumerable pawn960Knight()
        {
            var gameObject = new GameObject();

            Game game = gameObject.AddComponent<Game>();

            game.Start();

            int position = Random.Range(0, game.piecepositionList.Count);

            GameObject knight = game.GetPosition(position, 0);
            Chessman knighted = knight.GetComponent<Chessman>();
            Assert.AreEqual("white_knight", knighted);


            yield return null;
        }

        [UnityTest]
        public IEnumerable pawn960KingBetweenRooks()
        {
            var gameObject = new GameObject();

            Game game = gameObject.AddComponent<Game>();

            game.Start();

            int position = Random.Range(0, game.piecepositionList.Count);

            GameObject rook1 = game.GetPosition(position, 0);
            Chessman rooked = rook1.GetComponent<Chessman>();

            GameObject rook2 = game.GetPosition(position, 0);
            Chessman rooked2 = rook2.GetComponent<Chessman>();

            GameObject king = game.GetPosition(position, 0);
            Chessman kinged = king.GetComponent<Chessman>();
            Assert.AreEqual("white_king", kinged);
            Assert.AreEqual("white_Rook", rooked2);
            Assert.AreEqual("white_Rook", rooked);


            yield return null;
        }

        [UnityTest]
        public IEnumerable pawn960queen()
        {
            var gameObject = new GameObject();

            Game game = gameObject.AddComponent<Game>();

            game.Start();

            int position = Random.Range(0, game.piecepositionList.Count);

            GameObject queen = game.GetPosition(position, 0);
            Chessman queened = queen.GetComponent<Chessman>();
            Assert.AreEqual("white_queen", queened);


            yield return null;
        }

    }
}

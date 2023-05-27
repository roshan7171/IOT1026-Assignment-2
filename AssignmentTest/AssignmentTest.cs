using Assignment;

namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void OpenLockedTest()
        {
            // Chest starts in the locked state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Locked);
            // Try and open the chest
            // Verify that  chest is still locked
            chest.Open();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Locked);
        }
        [TestMethod]
        public void OpenClosedTest()
        {
            // Create a new chest that is in the closed state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);
            //Try to open the chest 
            //Verify that chest is opened
            chest.Open();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Open);
        }
        [TestMethod]
        public void OpenOpenTest()
        {
            // Create a new chest that is in the open state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Open);
            //Verify that chest is still open
            chest.Open();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Open);
        }
        [TestMethod]
        public void CloseOpenTest()
        {
            // Create a new chest that is in the open state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Open);
            // Try to close the chest
            // Verify that the chest is closed
            chest.Close();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Closed);
        }

        [TestMethod]
        public void CloseClosedTest()
        {
            // Create a new chest that is in the closed state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);
            // Verify that the chest is still closed
            chest.Close();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Closed);
        }

        [TestMethod]
        public void CloseLockedTest()
        {
            // Create a new chest that is in the locked state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Locked);
            // Verify that the chest is still locked
            chest.Close();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Locked);
        }

        [TestMethod]
        public void LockClosedTest()
        {
            // Create a new chest that is in the closed state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);
            // Try to lock the chest
            // Verify that the chest is locked
            chest.Lock();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Locked);
        }

        [TestMethod]
        public void LockOpenTest()
        {
            // Create a new chest that is in the open state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Open);
            // Verify that the chest is still open
            chest.Lock();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Open);
        }

        [TestMethod]
        public void UnlockLockedTest()
        {
            // Create a new chest that is in the locked state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Locked);
            // Try to unlock the chest
            // Verify that the chest is unlocked
            chest.Unlock();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Unlocked);
        }

        [TestMethod]
        public void UnlockUnlockedTest()
        {
            // Create a new chest that is in the unlocked state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Unlocked);
            // Verify that the chest is still unlocked
            chest.Unlock();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Unlocked);
        }

        [TestMethod]
        public void UnlockClosedTest()
        {
            // Create a new chest that is in the closed state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);
            // Verify that the chest is still closed
            chest.Unlock();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Closed);
        }

        [TestMethod]
        public void UnlockOpenTest()
        {
            // Create a new chest that is in the open state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Open);
            // Verify that the chest is still open
            chest.Unlock();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Open);
        }
    }
}
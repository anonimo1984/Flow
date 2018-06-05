
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flow.Core.Tests
{
    [TestClass]
    public class PerceptionTests
    {

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void ThePerceptionClassImplementsTheIAdequacyInterfaceToAdaptTheUserInterfaceToAdequacyPrinciple()
        {
            Perception.Perception perception;

            perception = new Perception.Perception();

            Assert.IsNotNull(perception.GetType().GetInterface("IAdequacy"));
        }
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void ThePerceptionClassImplementsTheIAligmentInterfaceToUserInterfaceElementesAreCentredOr()
        {
            Perception.Perception perception;

            perception = new Perception.Perception();

            Assert.IsNotNull(perception.GetType().GetInterface("IAligment"));
        }
        /// <summary>
        /// El principio del cerramiento o principio de cierre afirma que las líneas 
        /// que circundan una superficie se captan, en igualdad de condiciones, 
        /// más fácilmente como unidad o como figura si comparamos con otras que se unen entre sí.
        /// </summary>
        [TestMethod]
        public void GestaltPrinciplesTests()
        {


        }
    }
}

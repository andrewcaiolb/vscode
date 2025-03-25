using NUnit.Framework;
using Moq;
using backend.src.controllers;
using backend.src.models;
using backend.src.services;

namespace backend.tests
{
    [TestFixture]
    public class UnitTests
    {
        private Mock<FeedbackService> _feedbackServiceMock;
        private Mock<PdiService> _pdiServiceMock;
        private Mock<UserService> _userServiceMock;
        private FeedbackController _feedbackController;
        private PdiController _pdiController;
        private UserController _userController;

        [SetUp]
        public void Setup()
        {
            _feedbackServiceMock = new Mock<FeedbackService>();
            _pdiServiceMock = new Mock<PdiService>();
            _userServiceMock = new Mock<UserService>();

            _feedbackController = new FeedbackController(_feedbackServiceMock.Object);
            _pdiController = new PdiController(_pdiServiceMock.Object);
            _userController = new UserController(_userServiceMock.Object);
        }

        [Test]
        public void CreateFeedback_ShouldReturnCreatedFeedback()
        {
            // Arrange
            var feedback = new Feedback { Id = 1, UserId = 1, Comment = "Great job!", Date = DateTime.Now };
            _feedbackServiceMock.Setup(service => service.AddFeedback(It.IsAny<Feedback>())).Returns(feedback);

            // Act
            var result = _feedbackController.CreateFeedback(feedback);

            // Assert
            Assert.AreEqual(feedback, result);
        }

        [Test]
        public void GetAllFeedbacks_ShouldReturnListOfFeedbacks()
        {
            // Arrange
            var feedbackList = new List<Feedback>
            {
                new Feedback { Id = 1, UserId = 1, Comment = "Great job!", Date = DateTime.Now },
                new Feedback { Id = 2, UserId = 2, Comment = "Needs improvement.", Date = DateTime.Now }
            };
            _feedbackServiceMock.Setup(service => service.GetAllFeedbacks()).Returns(feedbackList);

            // Act
            var result = _feedbackController.GetFeedbacks();

            // Assert
            Assert.AreEqual(feedbackList, result);
        }

        // Additional tests for PdiController and UserController can be added here
    }
}
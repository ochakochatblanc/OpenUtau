using System;
using OpenUtau.Core.Editing;
using NUnit.Framework;

namespace OpenUtau.Core.Editing.Tests;

public class AddPhoneticHintsTests
{
    [Test]
    public void AddPhoneticHints_Should_()
    {
        // Arrange
            var sut = new AddPhoneticHints();
            
        // Act
        var result = sut.AddPhoneticHints();

        // Assert
            Assert.That(result, Is.Not.Null);
    }
}
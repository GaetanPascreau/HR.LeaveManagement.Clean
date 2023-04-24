using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Logging;
using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails;
using HR.LeaveManagement.Application.MappingProfiles;
using HR.LeaveManagement.Application.UnitTests.Mocks;
using HR.LeaveManagement.Domain;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.UnitTests.Features.LeaveTypes.Queries
{
    public class GetLeaveTypeDetailsQueryHandlerTests
    {
        private IMapper _mapper;
        private Mock<ILeaveTypeRepository> _mockRepo;

        public GetLeaveTypeDetailsQueryHandlerTests()
        {
            _mockRepo = MockLeaveTypeRepository.GetMockLeaveTypeRepository();

            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<LeaveTypeProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
        }

        [Fact]
        public async Task GetLeaveTypeDetailsTest()
        {
            // Arrange
            var handler = new GetLeaveTypeDetailsQueryHandler(_mapper, _mockRepo.Object);

            // Act
            var index = 2;
            var result = await handler.Handle(new GetLeaveTypeDetailsQuery(index), CancellationToken.None);

            // Assert
            result.ShouldBeOfType<LeaveTypeDto>();
        }
    }
}

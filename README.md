
# ActionMill

ActionMill is a small proof of concept .NET library I am developing that will help turn workflows into a managed queue of action, where you choose how many actions can run in parallel then the library handles timing, scheduling and logging with full control over each action to pause, resume, and cancel with the ability to specify custom behavior of what happens once execution is over.

---


# Development

Creating the library in an inside out fashion where the main focus is first around how the data is shaped and handled via logging, interfaces and DTOs before implementing the functionality. Gives more perspective into the needs of each segment without worrying too much about the code itself - yet.

# Roadmap and features

- FIFO queue based execution of methods with a configurable maximum parallel limit.
- Support for synchronous and asynchorous code.
- Dependency Injection with global access to running mills and standalone actions/jobs.
- Daisy chaining mills and actions for ease of use.

# Vision

ActionMill does not attempt to replace the factory pattern or likewise since it is mainly focused on queued jobs that require a one-time setup and a hands off operation like how many times a task should fail, when is it cancelled and what should happen after execution. Parsing a list of files or writing a linear script, it will help by providing an already established framework.

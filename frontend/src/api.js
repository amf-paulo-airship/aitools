const API_PORT = 5031;

const fetchNames = async () => {
  try {
    const response = await fetch(`http://localhost:${PORT}/list-names`);
    if (!response.ok) {
      throw new Error('Network response was not ok ' + response.statusText);
    }
    const data = await response.json();
    return data;
  } catch (error) {
    console.error('There has been a problem with your fetch operation:', error);
  }
}


//TODO: EXERCISE #7 - Using CoPilot Chat refactor this code using Pros and Cons prompt strategy